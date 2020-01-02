using System;

namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing OracleConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening OracleConnection");
        }
    }
}
