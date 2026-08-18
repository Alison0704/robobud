using RoboBud.Core.DTOs;
using RoboBud.Core.Enums;

namespace RoboBud.Core.Interfaces.Repositories;

public interface IRobotRepository
{
    RobotDataDto? GetRobotById(int id);

    void UpdateRobotName(int id, string name);

    void UpdateRobotLevel(
        int robotId,
        RobotLevelType type,
        int percentage
    );
}