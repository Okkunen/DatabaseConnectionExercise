using System;

namespace DatabaseConnectionExercise
{
    public class DbCommand
    {
        private readonly DbConnection Connection;
        public string Instruction { get; private set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
            {
                throw new InvalidOperationException("Connection cannot be null");
            }

            if (instruction == null || instruction == "")
            {
                throw new InvalidOperationException("Instruction message cannot be empty");
            }

            Connection = connection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(this.Instruction);
            Connection.Close();
        }
    }
}
