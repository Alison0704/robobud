using DAL;
namespace BLL;

public interface IGameService
{
    string Name { get; }
    void Play(RoboBud robot);
}