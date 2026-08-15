namespace Core;

public interface IRoboBud
{
    RobotStatus GetStatus();
    void SetStatus(RobotStatus status);
}