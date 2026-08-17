namespace BLL;

public class PomodoroTimerService
{
    public async Task StartAsync(
        int durationMinutes,
        CancellationToken cancellationToken = default)
    {
        if (durationMinutes <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(durationMinutes),
                "Duration must be greater than zero.");
        }

        TimeSpan remainingTime = TimeSpan.FromMinutes(durationMinutes);

        while (remainingTime > TimeSpan.Zero)
        {
            cancellationToken.ThrowIfCancellationRequested();

            Console.Write(
                $"\rTime remaining: {remainingTime:mm\\:ss}"
            );

            await Task.Delay(
                TimeSpan.FromSeconds(1),
                cancellationToken
            );

            remainingTime -= TimeSpan.FromSeconds(1);
        }

        Console.WriteLine("\nPomodoro completed!");
    }
}