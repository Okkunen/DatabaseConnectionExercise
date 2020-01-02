using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code for testing
            var sqlConnection = new SqlConnection("Connection string");
            sqlConnection.Open();
            sqlConnection.Close();
            var oracleConnection = new OracleConnection("Connection string");
            oracleConnection.Open();
            oracleConnection.Close();
            Console.ReadLine();
            //var errorTest = new SqlConnection("");

            var dbCommand = new DbCommand(sqlConnection, "Instructions sent to the database");
            dbCommand.Execute();
            Console.ReadLine();

            var dbCommandOracle = new DbCommand(oracleConnection, "Instructions sent to the database");
            dbCommandOracle.Execute();
            Console.ReadLine();
        }
    }
}
