using System.Net;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Options;

namespace K.Fit.Api.Service.FileService;

public class FileService : IFileService
{
    private static string BUCKET_NAME = "files";

    public FileService(IOptions<MinioConfig> config)
    {
        _config = config;
    }

    private readonly IOptions<MinioConfig> _config;

    private AmazonS3Client GetS3Client()
    {
        var config = _config.Value;
        var credentials = new BasicAWSCredentials(config.Username, config.Password);

        var s3Config = new AmazonS3Config
        {
            RegionEndpoint = RegionEndpoint.EUWest2,
            ServiceURL = config.Url,
            ForcePathStyle = true, // MUST be true to work correctly with MinIO server, 
        };

        return new AmazonS3Client(credentials, s3Config);
    }

    public Task<string> CreateUploadUrl()
    {
        throw new NotImplementedException();
    }

    public async Task<DownloadFileResponse> DownloadFileAsync(string fileGid)
    {
        var client = GetS3Client();
        var request = new GetObjectRequest()
        {
            Key = "images/" + fileGid,
            BucketName = BUCKET_NAME,
        };

        var response = await client.GetObjectAsync(request);

        if (response is null || response.HttpStatusCode != HttpStatusCode.OK)
        {
            throw new ArgumentException("File not found");
        }

        return new DownloadFileResponse()
        {
            OutputStream = response.ResponseStream,
            ContentType = response.Headers.ContentType
        };
    }

    public async Task<string> UploadFileAsync(string fileGid, IFormFile file)
    {
        var client = GetS3Client();
        //await using var fileStream = file.OpenReadStream();
        var fileExtension = file.FileName.LastIndexOf(".") > -1
            ? file.FileName.Substring(file.FileName.LastIndexOf("."))
            : "";

        var fileGidWithExtension = fileGid + fileExtension;

        var request = new PutObjectRequest()
        {
            Key = "images/" + fileGidWithExtension,
            BucketName = BUCKET_NAME,
            InputStream = file.OpenReadStream(),
            AutoCloseStream = true,
            ContentType = file.ContentType
        };

        try
        {
            await client.PutObjectAsync(request);
        }
        catch (AmazonS3Exception ex)
        {
            if (ex.Message == "The specified bucket does not exist")
            {
                await client.PutBucketAsync(new PutBucketRequest()
                {
                    BucketName = BUCKET_NAME
                });
            }

            throw ex;
        }

        var metaData = await client.GetObjectMetadataAsync(new GetObjectMetadataRequest()
        {
            BucketName = BUCKET_NAME,
            Key = "images/" + fileGidWithExtension
        });

        return client.GetPreSignedURL(new GetPreSignedUrlRequest()
        {
            Protocol = Protocol.HTTP,
            BucketName = BUCKET_NAME,
            Key = "images/" + fileGidWithExtension,
            Expires = DateTime.Now.AddHours(1)
        });
    }
}