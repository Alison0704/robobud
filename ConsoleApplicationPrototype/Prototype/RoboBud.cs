public class RoboBud
{
    private string Name { get; set; }
    private int Age { get; set; }
    private double HappinessLevel{ get; set; }

    public RoboBud(string name, int age, double happinessLevel)
    {
        Console.WriteLine("Your RoboBud has been born!");
        Console.WriteLine("Give a name to your RoboBud:");
        Console.WriteLine($"Meet {Name}!");
        Name = name;
        Age = age;
        HappinessLevel = happinessLevel;
    }

    public void GetAge()
    {
        Console.WriteLine($"RoboBud is {Age} years old.");
    }
    public void SetAge(int age)
    {
        Age = age;
    }

    public void GetHappinessLevelMessage()
    {
        Console.WriteLine($"RoboBud's happiness level is {HappinessLevel}.");
    }
    public double GetHappinessLevel()
    {
        return HappinessLevel;
    }

    public void SetHappinessLevel(double happinessLevel)
    {
        HappinessLevel = happinessLevel;
    }


}