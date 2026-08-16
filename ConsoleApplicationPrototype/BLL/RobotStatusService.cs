using Core;
using DAL;

namespace BLL;

public class RobotStatusService
{
    public RobotStatus DetermineStatus(
        int happiness,
        int energy)
    {
        if (happiness < 40 && energy < 40)
        {
            return RobotStatus.REFUSE;
        }

        if (happiness < 40 || energy < 40)
        {
            return RobotStatus.RELUCTANT;
        }

        return RobotStatus.ACCEPT;
    }

    public bool CanReceiveTask(RobotStatus status)
    {
        return status switch
        {
            RobotStatus.REFUSE => false,
            RobotStatus.RELUCTANT => Random.Shared.Next(2) == 1,
            RobotStatus.ACCEPT => true,

            _ => throw new ArgumentOutOfRangeException(
                nameof(status)
            )
        };
    }

    public void IncreaseHappiness(RoboBud robot, int amount)
    {
        robot.HappyLevel.Percentage = Math.Min(robot.HappyLevel.Percentage + amount, 100);
    }
}