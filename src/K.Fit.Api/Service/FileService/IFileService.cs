namespace K.Fit.Api.Service.FileService;

public interface IFileService
{
    public Task<string> CreateUploadUrl();
    public Task<Stream> DownloadFileAsync(string fileGid);
}