using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SystemMadruga
{
    public class CRUD
    {
        static string conexao = "server=127.0.0.1;uid=root;pwd=root;database=madrugas";

        //METODOS
        static string PegarNome()
        {
            string nomeusuario;

           
            do
            {
                Console.WriteLine("Digite o nome");
                nomeusuario = Console.ReadLine(); 

             
                if (string.IsNullOrWhiteSpace(nomeusuario))
                {
                    Console.WriteLine("Erro: Digite um nome válido e que não esteja em branco.");
                }

             
            } while (string.IsNullOrWhiteSpace(nomeusuario));

            
            Console.WriteLine("Nome registrado com sucesso!");

       
            return nomeusuario;
        }


        static string PegarTelefone()
        {
            string telefone =PegarTelefone();
            Console.WriteLine("Digite o telefone");
            return Console.ReadLine();
        }
        static string PegarEmail()
        {
            Console.WriteLine("Digite o email");
            return Console.ReadLine();
        }
        static string PegarEndereco()
        {
            Console.WriteLine("Digite o endereço");
            return Console.ReadLine();
        }
        static string PegarCivil()
        {
            
            Console.WriteLine("Digite o estado civíl (Casado/Solteiro)");
            return Console.ReadLine();
        }
        static string PegarSexo()
        {
            Console.WriteLine("Digite o sexo (F = Feminino/M = Masculino)");
            return Console.ReadLine();
        }
        static string PegarSenha()
        {
            Console.WriteLine("Digite a senha");
            return Console.ReadLine();
        }
        static double PegarValor()
        {
            Console.WriteLine("Digite o valor");
            return double.Parse(Console.ReadLine());
        }
        static string PegarCpf()
        {
            Console.WriteLine("Digite o CPF");
            return Console.ReadLine();
        }

        public void Login()
        {
            string email = PegarEmail();
            string senha = PegarSenha();
            using (var con = new MySqlConnection(conexao))
                con.Open();
                string sqlSelect = ("select * from funcionarios where email_func = @email and senha_func = @senha");
                var cmd = new MySqlCommand(sqlSelect);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
        }
        // FIM DOS METODOS
        // CADASTRO
        public void CadastroFuncionario()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastro de Funcionário --\n");
            string nome = PegarNome();
            string telefone = PegarTelefone();
            string email = PegarEmail();
            string endereco = PegarEndereco();
            string civil = PegarCivil();
            string sexo = PegarSexo();
            string senha = PegarSenha();

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
                Console.WriteLine("-- Funcionário cadastrado --");
            }
        }
        public void CadastroFornecedor()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastro de Fornecedor --\n");
            string nome = PegarNome();
            string telefone = PegarTelefone();
            string email = PegarEmail();
            string endereco = PegarEndereco();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into fornecedores (nome_forn, telefone_forn, email_forn, endereco_forn) values (@nome, @telefone, @email, @endereco)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.ExecuteNonQuery();
                Console.WriteLine("-- Fornecedor cadastrado --");
            }
        }
        public void CadastroProduto()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastro de Produtos --\n");
            string nome = PegarNome();
            double valor = PegarValor();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into produtos (nome_prod,valor_prod ) values (@nome, @valor)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.ExecuteNonQuery();
                Console.WriteLine("-- Produto cadastrado --");
            }

        }

        public void CadastroSocio()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastro de Sócios --\n");
            string nome = PegarNome();
            string email = PegarEmail();
            string cpf = PegarCpf();
            string telefone = PegarTelefone();

            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                var cmd = new MySqlCommand("insert into socios (nome_soc,email_soc, cpf_soc, telefone_soc ) values (@nome, @email, @cpf, @telefone)", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("cpf", cpf);
                cmd.Parameters.AddWithValue("telefone", telefone);
                cmd.ExecuteNonQuery();
                Console.WriteLine("-- Sócio cadastrado --");
            }
        }

        // FIM DO CADASTRO
        // LISTAGEM

        public void ListarFuncionario()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de funcionários --\n");
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from funcionarios";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " - " + rdr[1] + " Telefone: " + rdr[2] + " " + rdr[3] + " " + rdr[4] + "\n    " + rdr[5] + " Endereço: " + rdr[6] + " Sexo: " + rdr[7]);
                }
            }
        }

        public void ListarFornecedor()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de fornecedores --\n");
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from fornecedores";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " - " + rdr[1] + " Telefone: " + rdr[2] + " " + rdr[3] + " Endereço: " + rdr[4]);
                }
            }
        }

        public void ListarProduto()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de produtos --\n");
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from produtos";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " - " + rdr[1] + " Valor: R$" + rdr[2]);
                }
            }
        }

        public void ListarSocio()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de sócios --\n");
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = "select * from socios";
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " - " + rdr[1] + " " + rdr[2] + " CPF: " + rdr[3] + " Telefone: " + rdr[4]);
                }
            }
        }

        public void ListarCorte()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de cortes --\n");
            using (var con = new MySqlConnection(conexao))
            {
                con.Open();
                string sqlSelect = ("SELECT \r\n    co.cod_corte,\r\n    func.nome_func AS Barbeiro,\r\n\tcli.nome_cli AS Cliente,\r\n    co.data_corte\r\nFROM corte co\r\nJOIN clientes cli ON cli.cod_cli = co.cod_cli\r\nJOIN funcionarios func ON func.cod_func = co.cod_func order by data_corte;");
                var cmd = new MySqlCommand(sqlSelect, con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]+ " - Barbeiro: "+rdr[1]+"\n    Cliente: " + rdr[2]+"\n    Horário: " + rdr[3]);
                }
            }
        }

        // FIM DA LISTAGEM
        // ALTERAÇÃO

        public void AlterarFuncionario()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de funcionários --\n");
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
                Console.WriteLine("-- Funcionário alterado --");
            }
        }

        public void AlterarFornecedor()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de fornecedores --\n");
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
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.ExecuteNonQuery();
                Console.WriteLine("-- Fornecedor alterado --");
            }
        }
        public void AlterarProduto()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de produtos --\n");
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
                Console.WriteLine("-- Produto atualizado --");
            }
        }
        public void AlterarSocio()
        {
            Console.Clear();
            Console.WriteLine("-- Lista de sócios --\n");
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
                Console.WriteLine("-- Sócio atualizado --");
            }
        }
    }
}
