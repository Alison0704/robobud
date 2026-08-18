namespace RoboBud.Controller;
public class RobotController
{
    private readonly RobotService _robotService;

    public RobotController(RobotService robotService)
    {
        _robotService = robotService;
    }
}