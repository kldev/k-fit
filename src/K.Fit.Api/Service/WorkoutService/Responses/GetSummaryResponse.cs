namespace K.Fit.Api.Service.WorkoutService.Responses;

public class GetSummaryResponse
{
    public string Period { get; set; } = string.Empty;
    public decimal Distance { get; set; } = 0.0M;
}