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

    public void DecreaseHappiness(RoboBud robot, int amount)
    {
        robot.HappyLevel.Percentage = Math.Max(robot.HappyLevel.Percentage - amount, 0);
    }

    public void IncreaseEnergy(RoboBud robot, int amount)
    {
        robot.EnergyLevel.Percentage = Math.Min(robot.EnergyLevel.Percentage + amount, 100);
    }

    public void DecreaseEnergy(RoboBud robot, int amount)
    {
        robot.EnergyLevel.Percentage = Math.Max(robot.EnergyLevel.Percentage - amount, 0);
    }
}