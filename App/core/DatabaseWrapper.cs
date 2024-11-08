using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101088_utspbo.App.core
{
    internal class DatabaseWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "postgres";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "2006Zahra.";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection; 
        private static NpgsqlCommand command;

        public static void openConnection()
        {
            connection= new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME}; Password={DB_PASSWORD}; Port{DB_PORT};Database={DB_DATABASE}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;

        }
        public static void closeConnection()
        {
            connection.Close(); 
            command.Parameters.Clear();
        }
        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection(); 
                DataTable dataTable = new DataTable(); 
                command.CommandText = query;
                if (parameters != null) ;
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
            }
        }
    }
}
