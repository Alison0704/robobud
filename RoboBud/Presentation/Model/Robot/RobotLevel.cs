using RoboBud.Presentation.Model.Type;

namespace RoboBud.Presentation.Model.Robot;

public class RobotLevel
{
    public RobotLevelType Type { get; set; }

    private int _percentage;

    public int Percentage
    {
        get => _percentage;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Percentage must be between 0 and 100.");
            }

            _percentage = value;
        }
    }
}