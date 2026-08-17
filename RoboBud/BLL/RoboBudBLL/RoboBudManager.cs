using RoboBud.Presentation.Model.Robot;
using RoboBud.Presentation.Model.Type;
using RoboBudModel = RoboBud.Presentation.Model.Robot.RoboBud;

namespace BLL;

public sealed class RoboBudManager
{
    private static RoboBudManager? _instance;

    public RoboBudModel Robot { get; }

    private RoboBudManager()
    {
        Robot = new RoboBudModel(
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