namespace K.Fit.Api.Service.FileService;

public class MinioConfig
{
    public const string TAG_NAME = "Minio";

    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}