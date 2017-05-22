using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC
{
    class Editar
    {

        static void Main(string[] args)
        {
            NpgsqlConnection conexao = ConnectionFactory.CreateConnection();

            string textoEditar = @"update editora set nome = :nome, email = :email where id = :id";

            NpgsqlCommand comando = new NpgsqlCommand(textoEditar, conexao);


            comando.Parameters.Add(new NpgsqlParameter("nome", "Jorge"));
            comando.Parameters.Add(new NpgsqlParameter("email", "Jorge@jorge"));
            comando.Parameters.Add(new NpgsqlParameter("id", 1));

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
