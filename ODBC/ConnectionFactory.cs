using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC
{
    class ConnectionFactory
    {
        public static NpgsqlConnection CreateConnection() {
            //string stringDeConexao = @"Server=127.0.0.1;Port=5432;User Id=postgres;Password=1q2w3e4r;Database=teste;";
            string servidor = @"localhost";
            string porta = @"5432";
            string userId = @"postgres";
            string password = @"1q2w3e4r";
            string database = @"teste";


            StringBuilder connectionString = new StringBuilder();

            connectionString.Append("Server=");
            connectionString.Append(servidor);
            connectionString.Append(";Port=");
            connectionString.Append(porta);
            connectionString.Append(";User Id=");
            connectionString.Append(userId);
            connectionString.Append(";Password=");
            connectionString.Append(password);
            connectionString.Append(";Database=");
            connectionString.Append(database);


            return new NpgsqlConnection(connectionString.ToString());
        }
    }
}
