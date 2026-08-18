
namespace RoboBud.DAL.Model.Robot;

public class RobotEntity
{
    #region Fields
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    #endregion
}