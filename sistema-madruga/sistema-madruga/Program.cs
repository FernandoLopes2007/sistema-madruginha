
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_madruga
{
    internal class Program
    {
        static string conexao = "server=127.0.0.1;uid=root;pwd=root;database=madrugas";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-- Bem-Vindo ao sistema Madruga's Barber --");
                Console.WriteLine("1 - Cadastro\n2 - Lista\n3 - Alterar\nq - Sair\n");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("-- Área de Cadastro --");
                        AreaCadastro();
                        break;
                    case "2":
                        Console.WriteLine("-- Área de Listagem --");
                        AreaListagem();
                        break;
                    case "3":
                        Console.WriteLine("-- Área de Alteração --");
                        AreaAlteracao();
                        break;
                    case "q":
                        Console.WriteLine("-- Programa encerrado --");
                        return;
                    default:
                        Console.WriteLine("--Opção Incorreta --");
                        break;
                }

            }
        }
        // CADASTRO (vai virar DLL depois)
        static void AreaCadastro()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção para cadastrar");
                Console.WriteLine("1 - Funcionário\n2 - Fornecedor\n3 - Produtos\n4 - Sócios\nq - Voltar");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("-- Cadastro de Funcionário --");
                        CadastroFuncionario();
                        break;
                    case "2":
                        Console.WriteLine("-- Cadastro de Fornecedor --");
                        CadastroFornecedor();
                        break;
                    case "3":
                        Console.WriteLine("-- Cadastro de Produtos --");
                        CadastroProduto();
                        break;
                    case "4":
                        Console.WriteLine("-- Cadastro de Sócios --");
                        CadastroSocio();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        return;
                    default:
                        Console.WriteLine("-- Opção incorreta --");
                        break;
                }
            }
        }
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
        static void CadastroFornecedor()
        {
            Console.WriteLine("Digite o nome do fornecedor:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do fornecedor:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o email do fornecedor:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o endereço do fornecedor:");
            string endereco = Console.ReadLine();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into fornecedores (nome_forn, telefone_forn, email_forn, endereco_forn) values (@nome, @telefone, @email, @endereco)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Fornecedor cadastrado");
            }
        }
        static void CadastroProduto()
        {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto");
            double valor = double.Parse(Console.ReadLine());

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into produtos (nome_prod,valor_prod ) values (@nome, @valor)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Produto cadastrado");
            }

        }

        static void CadastroSocio()
        {
            Console.WriteLine("Digite o nome do sócio:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do sócio:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o CPF do sócio:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Diite o telefone do sócio");
            string telefone = Console.ReadLine();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into socios (nome_soc,email_soc, cpf_soc, telefone_soc ) values (@nome, @email, @cpf, @telefone)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("cpf", cpf);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Sócio cadastrado");
            }
        }
        // FIM DO CADASTRO (vai virar DLL depois)
        static void AreaListagem()
        {

        }
        static void AreaAlteracao()
        {

        }
    }
}