using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5PolymorphismExercises.Exercise_1__Design_a_dataBase_connection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL Connection.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open SQL Connection.");
        }
    }
}
