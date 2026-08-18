using RoboBud.Core.Interfaces.Repositories;
namespace RoboBud.BLL.Robot;
public class RobotService
{
    private readonly IRobotRepository _repository;

    public RobotService(IRobotRepository repository)
    {
        _repository = repository;
    }
}