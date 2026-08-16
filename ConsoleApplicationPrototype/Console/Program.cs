using BLL;
using DAL;

CurrentTimeService currentTimeService = new();
PomodoroTimerService pomodoroService = new();
RobotStatusService robotStatusService = new();
GuessMyNumberService guessMyNumberService = new(robotStatusService);
RoboBud robot = new RoboBud(
    "RoboBud",
    new Core.RobotLevel
    {
        Type = Core.RobotLevelType.HAPPY,
        Percentage = 80
    },
    new Core.RobotLevel
    {
        Type = Core.RobotLevelType.ENERGIZED,
        Percentage = 80
    }   
);

Console.WriteLine("Select a task:");
Console.WriteLine("1. Request the current time");
Console.WriteLine("2. Start a Pomodoro timer");
Console.WriteLine("3. Play Guess My Number");

string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        DateTime currentTime = currentTimeService.GetCurrentTime();

        Console.WriteLine(
            $"Current time: {currentTime:HH:mm:ss}"
        );
        break;

    case "2":
        Console.Write("Enter duration in minutes: ");

        if (int.TryParse(Console.ReadLine(), out int minutes))
        {
            await pomodoroService.StartAsync(minutes);
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        break;
    case "3":
        guessMyNumberService.Play(robot);
        break;  


    default:
        Console.WriteLine("Invalid task.");
        break;
}

Console.WriteLine("Play a game with RoboBud!");

Console.WriteLine(robot.HappyLevel.Percentage);

