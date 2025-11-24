
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
                Console.Clear();
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
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- Escolha uma opção para cadastrar --");
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
            Console.WriteLine("Digite o telefone do sócio");
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

        // LISTAGEM
        static void AreaListagem()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- Escolha uma opção para listar --");
                Console.WriteLine("1 - Funcionário\n2 - Fornecedor\n3 - Produto\n4 - Sócio\nq - Voltar");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("-- Lista de funcionários --");
                        ListarFuncionario();
                        break;
                    case "2":
                        Console.WriteLine("-- Lista de fornecedores --");
                        ListarFornecedor();
                        break;
                    case "3":
                        Console.WriteLine("-- Lista de produtos --");
                        ListarProduto();
                        break;
                    case "4":
                        Console.WriteLine("-- Lista de sócios --");
                        ListarSocio();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        return;
                    default:
                        Console.WriteLine("-- Opção Incorreta --");
                        break;
                }
            }
        }

        static void ListarFuncionario()
        {
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from funcionarios";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]+" - "+rdr[1]+" Telefone: " + rdr[2]+" "+ rdr[3]+ " "+ rdr[4] +"\n    "+ rdr[5] +" Endereço: "+ rdr[6]+" Sexo: "+rdr[7]+" Senha: " + rdr[8]);
                }
            }
            Console.ReadKey();
        }
        
        static void ListarFornecedor()
        {
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from fornecedores";
                var cmd = new MySqlCommand( sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]+" - " + rdr[1]+" Telefone: " + rdr[2]+" " + rdr[3]+" Endereço: " + rdr[4]);
                }
            }
            Console.ReadKey();
        }

        static void ListarProduto()
        {
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from produtos";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read()) 
                {
                    Console.WriteLine(rdr[0]+" - " + rdr[1]+" Valor: R$"+rdr[2]);
                }
            }
            Console.ReadKey();
        }

        static void ListarSocio()
        {
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from socios";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read()) 
                {
                    Console.WriteLine(rdr[0]+" - "+rdr[1]+" "+rdr[2]+" CPF: "+rdr[3]+" Telefone: " + rdr[4]);
                }
            }
            Console.ReadKey();
        }

        // FIM DA LISTAGEM (vai virar DLL depois)
        static void AreaAlteracao()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- Escolha uma opção para alterar --");
                Console.WriteLine("1 - Funcionário\n2 - Fornecedor\n3 - Produto\n4 - Sócio\nq - Voltar");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("-- Lista de funcionários --");
                        AlterarFuncionario();
                        break;
                    case "2":
                        Console.WriteLine("-- Lista de fornecedores --");
                        AlterarFornecedor();
                        break;
                    case "3":
                        Console.WriteLine("-- Lista de produtos --");
                        AlterarProduto();
                        break;
                    case "4":
                        Console.WriteLine("-- Lista de sócios --");
                        AlterarSocio();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        return;
                    default:
                        Console.WriteLine("-- Opção Incorreta --");
                        break;
                }
            }
        }

        static void AlterarFuncionario()
        {
            ListarFuncionario();
            Console.WriteLine("Digite o código do funcionário a ser alterado");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome do funcionário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone do funcionário:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o novo email do funcionário:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o novo endereço do funcionário:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite o novo estado civíl do funcionário (Casado / Solteiro):");
            string civil = Console.ReadLine();
            Console.WriteLine("Digite o novo sexo do funcionário (F = feminino / M = masculino):");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite a nova senha do funcionário:");
            string senha = Console.ReadLine();
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlUpdate = "Update funcionarios set nome_func = @nome, telefone_func = @telefone, email_func = @email, status_func = @civil, endereço_func = @endereco, sexo_func = @sexo, senha_func = @senha  where cod_func = @cod";
                var cmd = new MySqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@civil", civil);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Funcionário alterado");

            }
        }
         static void AlterarFornecedor()
        {
            ListarFornecedor();
            Console.WriteLine("Digite o código do fornecedor a ser alterado");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome do fornecedor:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone do fornecedor:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o novo email do fornecedor:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o novo endereço do fornecedor:");
            string endereco = Console.ReadLine();
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlUpdate = ("Update fornecedores set nome_forn = @nome, telefone_forn = @telefone, email_forn = @email, endereco_forn = @endereco where cod_forn = @cod");
                var cmd = new MySqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@cod",cod);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Fornecedor alterado");
            }
        }

        static void AlterarProduto()
        {
            ListarProduto();
            Console.WriteLine("Digite o código do produto a ser alterado");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o novo valor do produto");
            double valor = double.Parse(Console.ReadLine());

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlUpdate = ("Update produtos set nome_prod = @nome, valor_prod = @valor where cod_prod = @cod");
                var cmd = new MySqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Produto atualizado");
            }
        }

        static void AlterarSocio()
        {
            ListarSocio();
            Console.WriteLine("Digite o código do sócio a ser alterado");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome do sócio:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o novo email do sócio:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o novo CPF do sócio:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone do sócio");
            string telefone = Console.ReadLine();
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlUpdate = ("Update socios set nome_soc = @nome, email_soc = @email, cpf_soc = @cpf, telefone_soc = @telefone where cod_soc = @cod");
                var cmd = new MySqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Sócio atualizado");
            }
        }
    }
}