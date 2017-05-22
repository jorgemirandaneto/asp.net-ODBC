using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC
{
    class Listar
    {
        static void Main(string[] args)
        {

            NpgsqlConnection conexao = ConnectionFactory.CreateConnection();

            string listar = @"select * from editora";

            NpgsqlCommand comando = new NpgsqlCommand(listar, conexao);

            conexao.Open();

            NpgsqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                string nome = resultado["nome"] as string;
                string email = resultado["email"] as string;

                Console.WriteLine("Nome: " + nome + "\n" +   "Email: " + email +"\n");
            }
        }
    }
}

