namespace DAL;

public class RoboBud
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double HappinessLevel { get; set; }

    public RoboBud(string name, int age, double happinessLevel)
    {
        Name = name;
        Age = age;
        HappinessLevel = happinessLevel;
    }
}
