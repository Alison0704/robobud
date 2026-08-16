using Core;
using DAL;

namespace BLL;

public sealed class RoboBudManager
{
    private static RoboBudManager? _instance;

    public RoboBud Robot { get; }

    private RoboBudManager()
    {
        Robot = new RoboBud(
            name: "RoboBud",
            happyLevel: new RobotLevel { Type = RobotLevelType.HAPPY, Percentage = 100 },
            energyLevel: new RobotLevel { Type = RobotLevelType.ENERGIZED, Percentage = 100 }
        );
    }

    public static RoboBudManager GetInstance()
    {
        if (_instance is null)
        {
            _instance = new RoboBudManager();
        }

        return _instance;
    }
}