namespace DatabaseConnection;

public class SqlConnection: DbConnection
{
    public override void Open()
    {
        Console.WriteLine("Opening SQL Connection.");
    }

    public override void Close()
    {
        Console.WriteLine("Closing SQL Connection.");
    }

    public SqlConnection(string connectionString) : base(connectionString)
    {
    }
}