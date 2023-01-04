namespace DatabaseConnection

{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection(" SQL String");
            var sqlCommand = new DbCommand(sqlConnection, "Instruction for sql server.");
            sqlCommand.Execute();

            var oracleConnection = new OracleConnection("Oracle string");
            var oracleCommand = new DbCommand(sqlConnection, "Instruction for oracle.");
            oracleCommand.Execute();
                                                
        }
    }
}