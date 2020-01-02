using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString) {
            if (connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Connection string cannot be empty");
            }

            ConnectionString = connectionString;
        }
       
        public DbConnection(string connectionString, TimeSpan timeOut)
            : this(connectionString)
        {
            TimeOut = timeOut;
        }

        public abstract void Open();

        public abstract void Close();

    }
}
