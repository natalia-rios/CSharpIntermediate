namespace DatabaseConnection;

public abstract class DbConnection
{
    private readonly string _connectionString;
    private readonly TimeSpan _timeout;

    public DbConnection(string connectionString)
    {
        if (String.IsNullOrEmpty(connectionString))
            throw new Exception("The connection string cannot be null or empty");

        _connectionString = connectionString;
    }

    public abstract void Open();
    public abstract void Close();
}