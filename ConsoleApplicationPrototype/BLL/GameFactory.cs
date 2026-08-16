using Core;

namespace BLL;

public static class GameFactory
{
    public static IGameService Create(GameType gameType)
    {
        return gameType switch
        {
            GameType.GuessMyNumber =>
                new GuessMyNumberService(new RobotStatusService()),

            _ => throw new ArgumentOutOfRangeException(
                nameof(gameType),
                gameType,
                "Unsupported game type."
            )
        };
    }
}