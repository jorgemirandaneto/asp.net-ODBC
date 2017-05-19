using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Npgsql;

namespace ODBC
{
    class InsereEditora
    {
        static void Main(string[] args)
        {
            string stringDeConexao = @"Server=127.0.0.1;Port=5432;User Id=postgres;Password=1q2w3e4r;Database=teste;";

            
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu email");
            string email = Console.ReadLine();

            NpgsqlConnection conexao = new NpgsqlConnection(stringDeConexao);

            string textoInsereEditora = @"insert into editora (nome, email) values ('?','?')";

            NpgsqlCommand comando = new NpgsqlCommand(textoInsereEditora, conexao);

            comando.Parameters.AddWithValue(@"nome", nome);

            comando.Parameters.AddWithValue(@"email", email);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
