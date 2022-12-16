namespace K.Fit.Api.Extensions;

public static class DateIsoExtension
{
    public static string ToPolandIso8601Format(this DateTime dateTimeUtc)
    {

        try
        {
            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Warsaw");
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, cstZone);
            return cstTime.ToString("O");
        }
        catch { }

        return dateTimeUtc.ToString("O");

    }
}