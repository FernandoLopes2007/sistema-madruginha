using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SystemMadruga
{
    public class CRUD
    {
        static string conexao = "server=127.0.0.1;uid=root;pwd=root;database=madrugas";

        // CADASTRO
        static void CadastroFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do funcionário:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o email do funcionário:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o endereço do funcionário:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite o estado civíl do funcionário (Casado / Solteiro):");
            string civil = Console.ReadLine();
            Console.WriteLine("Digite o sexo do funcionário (F = feminino / M = masculino):");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite a senha do funcionário:");
            string senha = Console.ReadLine();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into funcionarios (nome_func, telefone_func, email_func, endereço_func, status_func, sexo_func, senha_func) values (@nome, @telefone, @email, @endereco, @civil, @sexo, @senha)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@civil", civil);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Funcionário cadastrado");
            }
        }
    }
}
