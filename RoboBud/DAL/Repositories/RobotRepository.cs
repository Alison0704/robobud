using RoboBud.DAL.DBConnection;
public class RobotRepository
{
    private readonly DatabaseConnection _databaseConnection;

    public RobotRepository(DatabaseConnection databaseConnection)
    {
        _databaseConnection = databaseConnection;
    }

    public void Example()
    {
        using var connection = _databaseConnection.CreateConnection();

        connection.Open();

        // SELECT / INSERT / UPDATE / DELETE
    }
}