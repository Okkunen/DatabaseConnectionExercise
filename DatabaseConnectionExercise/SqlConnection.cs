using System;

namespace DatabaseConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing SqlConnection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening SqlConnection");
        }
    }
}
