using RoboBud.Core.Enums;
namespace RoboBud.DAL.Model.Robot;

public class RobotLevelEntity
{
    #region Fields
    public int Id { get; set; }
    public int RobotId { get; set; }
    public RobotLevelType Type { get; set; }
    public int Percentage { get; set; }
    #endregion
}