using K.Fit.Api.DAL;
using K.Fit.Api.Service.WorkoutService.Responses;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace K.Fit.Api.Service.WorkoutService;

public class WorkoutService : IWorkoutService
{
    private readonly FitContext _context;

    public WorkoutService(FitContext context)
    {
        _context = context;
    }

    public async Task<List<GetSummaryResponse>> GetSummaryAsync(Guid userGid)
    {
        await using var conn = _context.Database.GetDbConnection();

        var sql =
            @"select
                sum(""distance_km"") as distance, 
                to_char(""w_date"", 'YYYY-MM') as period     
              from fit.bike_w where ""user_id"" = (select ""id"" from fit.users where gid = @userGid)  group by 2 order by 2 desc";
        return (await conn.QueryAsync<GetSummaryResponse>(sql, new { userGid  })).ToList();
    }

    public async Task<List<object>> GetSummaryEFAsync(Guid userGid)
    {
        var query = await (_context.BikeWorkouts.Where(x=>x.WorkoutUser.Gid == userGid)
            .GroupBy(x => new { x.WorkoutDate.Year, x.WorkoutDate.Month },
            (key, grp) => new
            {
                PeriodYear = key.Year,
                PeriodMonth = key.Month, 
                Sum = grp.Sum(x => x.DistanceKm), 
                Count = grp.Count(),
                SumTime = grp.Sum(x => x.TimeMinutes)
            })).OrderByDescending(x => x.PeriodYear)
            .OrderByDescending(x=>x.PeriodYear)
            .ThenByDescending(y=>y.PeriodMonth)
            .ToListAsync();

        string FormatMonth(int x)
        {
            if (x < 10) return $"0{x}";
            return $"{x}";
        }

        var x = query.ToList().Select(x => new
        {
            Period = $"{x.PeriodYear}-" + FormatMonth(x.PeriodMonth),
            Sum = $"{x.Sum} km", Count = x.Count,
            Avg = $"{(decimal)x.Sum / (decimal)x.Count:0.00} km",
            SumTime = $"{((decimal)Math.Floor(((decimal)x.SumTime/(decimal)60))):0} hours {(x.SumTime % 60):00} minutes "
        });

        return x.ToList<object>();
    }
}
