using Core;
namespace DAL;

public class RoboBud
{
    public string Name { get; set; }

    public RobotLevel HappyLevel { get; set; }
    public RobotLevel EnergyLevel { get; set; }

    public RoboBud(string name, RobotLevel happyLevel, RobotLevel energyLevel)
    {
        Name = name;
        HappyLevel = happyLevel;
        EnergyLevel = energyLevel;
    }
}
