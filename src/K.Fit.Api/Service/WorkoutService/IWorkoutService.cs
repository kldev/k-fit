using K.Fit.Api.Service.WorkoutService.Responses;

namespace K.Fit.Api.Service.WorkoutService;

public interface IWorkoutService
{
    public Task<List<GetSummaryResponse>> GetSummaryAsync(Guid gid);
    public Task<List<object>> GetSummaryEFAsync(Guid gid);
}