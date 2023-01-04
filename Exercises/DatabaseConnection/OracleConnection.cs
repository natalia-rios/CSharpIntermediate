namespace DatabaseConnection;

public class OracleConnection: DbConnection
{
    public override void Open()
    {
        Console.WriteLine("Opening Oracle Connection.");
    }

    public override void Close()
    {
        Console.WriteLine("Closing Oracle Connection.");
    }

    public OracleConnection(string connectionString) : base(connectionString)
    {
    }
}