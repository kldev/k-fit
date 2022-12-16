namespace K.Fit.Api.Service.FileService;

public interface IFileService
{
    public Task<string> CreateUploadUrl();
    public Task<DownloadFileResponse> DownloadFileAsync(string fileGid);
    public Task<string> UploadFileAsync(string fileGid, IFormFile file);
}

public record DownloadFileResponse
{
    public Stream? OutputStream { get; set; }
    public string ContentType { get; set; } = string.Empty;
}