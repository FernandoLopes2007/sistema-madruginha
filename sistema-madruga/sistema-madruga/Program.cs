
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SystemMadruga;

namespace sistema_madruga
{
    internal class Program
    {
        static string conexao = "server=127.0.0.1;uid=root;pwd=root;database=madrugas";
        static CRUD crud = new CRUD();
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
                        crud.CadastroFuncionario();
                        break;
                    case "2":
                        crud.CadastroFornecedor();
                        break;
                    case "3":
                        crud.CadastroProduto();
                        break;
                    case "4":
                        crud.CadastroSocio();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("-- Opção incorreta --");
                        break;
                }
            }
        }

        // LISTAGEM
        static void AreaListagem()
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Escolha uma opção para listar --");
                Console.WriteLine("1 - Funcionário\n2 - Fornecedor\n3 - Produto\n4 - Sócio\n5 - Cortes\nq - Voltar");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        crud.ListarFuncionario();
                        Console.ReadKey();
                        break;
                    case "2":
                        crud.ListarFornecedor();
                        Console.ReadKey();
                        break;
                    case "3":
                        crud.ListarProduto();
                        Console.ReadKey();
                        break;
                    case "4":
                        crud.ListarSocio();
                        Console.ReadKey();
                        break;
                    case "5":
                        crud.ListarCorte();
                        Console.ReadKey();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("-- Opção Incorreta --");
                        break;
                }
            }
        }

        // ALTERAÇÃO
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
                        crud.AlterarFuncionario();
                        break;
                    case "2":
                        crud.AlterarFornecedor();
                        break;
                    case "3":
                        crud.AlterarProduto();
                        break;
                    case "4":
                        crud.AlterarSocio();
                        break;
                    case "q":
                        Console.WriteLine("-- Voltando --");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("-- Opção Incorreta --");
                        break;
                }
            }
        }  
    }
}
