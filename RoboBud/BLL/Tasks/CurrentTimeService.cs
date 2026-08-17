namespace BLL;

public class CurrentTimeService
{
    public DateTime GetCurrentTime()
    {
        return DateTime.Now;
    }

    public string GetCurrentTimeFormatted()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
}