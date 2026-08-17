using RoboBud.Presentation.Model.Robot;
using RoboBudModel = RoboBud.Presentation.Model.Robot.RoboBud;
namespace RoboBud.BLL.GameBLL;

public interface IGameService
{
    string Name { get; }
    void Play(RoboBudModel robot);
}