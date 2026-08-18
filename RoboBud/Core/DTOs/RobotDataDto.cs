namespace RoboBud.Core.DTOs;
public class RobotDataDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Happiness { get; set; }
    public int Energy { get; set; }
}