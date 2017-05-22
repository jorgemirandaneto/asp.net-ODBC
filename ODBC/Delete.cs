using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC
{
    class Delete
    {
        static void Main(string[] args)
        {
            NpgsqlConnection conexao = ConnectionFactory.CreateConnection();

            string textoDeleta = "delete from editora where id = :id";

            NpgsqlCommand comando = new NpgsqlCommand(textoDeleta, conexao);

            comando.Parameters.Add(new NpgsqlParameter(@"id", 2));

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
