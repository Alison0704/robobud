using Microsoft.Data.Sqlite;

namespace RoboBud.DAL.DBConnection;

public class DatabaseConnection
{
    private readonly string _connectionString;

    public DatabaseConnection(string databasePath)
    {
        _connectionString = $"Data Source={databasePath}";
    }

    public SqliteConnection CreateConnection()
    {
        return new SqliteConnection(_connectionString);
    }
}