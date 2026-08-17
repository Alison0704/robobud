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
            happyLevel: new RobotLevel { Type = RobotLevelType.HAPPY, Percentage = 70 },
            energyLevel: new RobotLevel { Type = RobotLevelType.ENERGIZED, Percentage = 70 }
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