using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section5PolymorphismExercises.Exercise_1__Design_a_dataBase_connection;

namespace Section5PolymorphismExercises.Exercise_2__Design_a_dataBase_command
{
    public class Exercise_2
    {
        public static void Execute()
        {
            var oracleConnection = new OracleConnection("kbwbqjvbf");
            var sqlConnection = new SqlConnection("knebgjqwfqb");
            var dbCommand = new DbCommand(oracleConnection, "instruction1");

            dbCommand.Execute();
        }
    }
}
