using System.Collections.ObjectModel;
using K.Fit.Api.Service.WorkoutService.Responses;

namespace K.Fit.Api.Service.WorkoutService;

public interface IWorkoutService
{
    public Task<ReadOnlyCollection<GetSummaryResponse>> GetSummaryAsync(Guid gid);
    public Task<ReadOnlyCollection<object>> GetKilosSummaryAsync(Guid gid);
    public Task<ReadOnlyCollection<object>> GetSummaryEFAsync(Guid gid);
}