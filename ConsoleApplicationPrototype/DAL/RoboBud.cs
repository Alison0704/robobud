using Core;
namespace DAL;

public class RoboBud
{
    public string Name { get; set; }
    public int Age { get; set; }

    public RobotLevel HappyLevel { get; set; }
    public RobotLevel EnergyLevel { get; set; }

    public RoboBud(string name, int age, RobotLevel happyLevel, RobotLevel energyLevel)
    {
        Name = name;
        Age = age;
        HappyLevel = happyLevel;
        EnergyLevel = energyLevel;
    }
}
