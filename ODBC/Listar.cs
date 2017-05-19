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
            string stringDeConexao = @"Server=127.0.0.1;Port=5432;User Id=postgres;Password=1q2w3e4r;Database=teste;";

            NpgsqlConnection conexao = new NpgsqlConnection(stringDeConexao);



            string listar = @"select * from editora";

            NpgsqlCommand comando = new NpgsqlCommand(listar, conexao);

            conexao.Open();

            NpgsqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                string nome = resultado["nome"] as string;
                string email = resultado["email"] as string;

                Console.WriteLine("Nome: " + nome + "   Email: " + email +"\n");
            }
        }
    }
}

