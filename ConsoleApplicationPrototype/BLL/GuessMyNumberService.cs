using DAL;

namespace BLL;

public class GuessMyNumberService : IGameService
{
    private const int MINIMUM_NUMBER = 1;
    private const int MAXIMUM_NUMBER = 100;
    private const int FAST_GUESS_LIMIT = 5;

    public string Name => "Guess My Number";

    private readonly RobotStatusService _robotStatusService;

    public GuessMyNumberService(RobotStatusService robotStatusService)
    {
        _robotStatusService = robotStatusService;
    }

    public void Play(RoboBud robot)
    {
        int secretNumber = Random.Shared.Next(
            MINIMUM_NUMBER,
            MAXIMUM_NUMBER + 1
        );

        int numberOfTurns = 0;
        bool guessedCorrectly = false;

        Console.WriteLine(
            $"I selected a number between {MINIMUM_NUMBER} and {MAXIMUM_NUMBER}."
        );

        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            numberOfTurns++;

            if (guess < secretNumber)
            {
                Console.WriteLine("My number is higher.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("My number is lower.");
            }
            else
            {
                guessedCorrectly = true;

                int happinessIncrease =
                    numberOfTurns <= FAST_GUESS_LIMIT ? 30 : 10;

                _robotStatusService.IncreaseHappiness(robot, happinessIncrease);

                Console.WriteLine(
                    $"Correct! You guessed it in {numberOfTurns} turns."
                );

                Console.WriteLine(
                    $"RoboBud's happiness increased by {happinessIncrease}%."
                );
            }
        }
    }
}