using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5PolymorphismExercises.Exercise_2__Design_a_dataBase_command
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection is null || string.IsNullOrWhiteSpace(instruction))
            {
                throw new System.InvalidOperationException("dbConnection needed.");
            }
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        private void RunInstruction(string instruction)
        {
            Console.WriteLine("Running instruction: {0}.", instruction);
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            RunInstruction(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
