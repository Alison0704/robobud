using BLL;
using RoboBud.Presentation.Model.Type;

namespace RoboBud.BLL.GameBLL;

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