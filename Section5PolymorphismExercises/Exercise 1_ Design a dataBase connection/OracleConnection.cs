using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5PolymorphismExercises.Exercise_1__Design_a_dataBase_connection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection.");
        }
    }
}
