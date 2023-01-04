namespace DatabaseConnection;

public class DbCommand
{
    private readonly DbConnection _dbConnection;
    private readonly string _instruction;

    public DbCommand(DbConnection dbConnection, string instruction)
    {
        if (dbConnection == null)
            throw new Exception("DbConnection cannot be null.");
        if (String.IsNullOrEmpty(instruction))
            throw new Exception("Instruction cannot be null or empty.");

        _dbConnection = dbConnection;
        _instruction = instruction;
    }

    public void Execute()
    {
        _dbConnection.Open();
        Console.WriteLine("Instruction: " + _instruction);
        _dbConnection.Close();
    }
}