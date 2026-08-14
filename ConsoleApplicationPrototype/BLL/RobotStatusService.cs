using Core;

namespace BLL;

public class RobotStatusService
{
    public bool CanReceiveTask(RobotStatus status)
    {
        return status == RobotStatus.ACCEPT;
    }
}