using System;

namespace Section5PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new System.InvalidOperationException("A connection string is required.");
            }
            ConnectionString = connectionString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
