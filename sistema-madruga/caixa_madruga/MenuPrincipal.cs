using caixa_madruga.Movimentação;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace caixa_madruga
{
    public partial class MenuPrincipal : Form
    {
        private List<Movimentacao> movimentacoes = new List<Movimentacao>();

        private string caminhoDados = Path.Combine(
            Application.StartupPath,
            "movimentacoes.txt"
        );

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void LimparMovimentacoesAntesDeSair()
        {
            try
            {
                File.WriteAllText(caminhoDados, ""); 
            }
            catch { }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CarregarMovimentacoes();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listView1.Items.Clear();

            foreach (var m in movimentacoes)
            {
                ListViewItem item = new ListViewItem(m.Data.ToString("dd/MM/yyyy"));
                item.SubItems.Add(m.Cliente);
                item.SubItems.Add(m.Tipo);
                item.SubItems.Add(m.Valor.ToString("F2"));

                listView1.Items.Add(item);
            }
        }

        
        private void menuNovaMovimentacao_Click(object sender, EventArgs e)
        {
            frmMovimentacao frm = new frmMovimentacao();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                movimentacoes.Add(frm.MovimentacaoSalva);
                AtualizarLista();
                SalvarMovimentacoes();
            }
        }

        
        private void CarregarMovimentacoes()
        {
            if (!File.Exists(caminhoDados))
                return;

            string[] linhas = File.ReadAllLines(caminhoDados);

            movimentacoes.Clear();

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] dados = linha.Split(';');

                if (dados.Length < 4) continue;

                Movimentacao m = new Movimentacao();

                DateTime.TryParse(dados[0], out DateTime data);
                m.Data = data;

                m.Cliente = dados[1];
                m.Tipo = dados[2];
                decimal.TryParse(dados[3], out decimal valor);

                m.Valor = valor;
                movimentacoes.Add(m);
            }
        }

        
        private void SalvarMovimentacoes()
        {
            using (StreamWriter sw = new StreamWriter(caminhoDados, false))
            {
                foreach (var m in movimentacoes)
                {
                    sw.WriteLine($"{m.Data:yyyy-MM-dd};{m.Cliente};{m.Tipo};{m.Valor}");
                }
            }
        }

        
        private void gerarRelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movimentacoes.Count == 0)
            {
                MessageBox.Show("Não há movimentações para gerar relatório.");
                return;
            }

            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo de Texto (*.txt)|*.txt";
            salvar.Title = "Salvar Relatório";
            salvar.FileName = $"Relatorio_Caixa_{DateTime.Now:dd-MM-yyyy_HH-mm}.txt";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(salvar.FileName))
                {
                    sw.WriteLine("BARBEARIA MADRUGA'S BARBER");
                    sw.WriteLine("RELATÓRIO DE MOVIMENTAÇÕES");
                    sw.WriteLine("---------------------------------------------");
                    sw.WriteLine($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm}\n");

                   
                    var entradas = movimentacoes.Where(m => m.Tipo == "Entrada").ToList();
                    sw.WriteLine("=== ENTRADAS ===");

                    if (entradas.Count == 0)
                    {
                        sw.WriteLine("Nenhuma entrada registrada.");
                    }
                    else
                    {
                        foreach (var m in entradas)
                        {
                            sw.WriteLine($"{m.Data:dd/MM/yyyy} - {m.Cliente} - R$ {m.Valor:F2}");
                        }
                    }

                    sw.WriteLine($"TOTAL DE ENTRADAS: R$ {entradas.Sum(m => m.Valor):F2}\n");

                    
                    var saidas = movimentacoes.Where(m => m.Tipo == "Saída").ToList();
                    sw.WriteLine("=== SAÍDAS ===");

                    if (saidas.Count == 0)
                    {
                        sw.WriteLine("Nenhuma saída registrada.");
                    }
                    else
                    {
                        foreach (var m in saidas)
                        {
                            sw.WriteLine($"{m.Data:dd/MM/yyyy} - {m.Cliente} - R$ {m.Valor:F2}");
                        }
                    }

                    sw.WriteLine($"TOTAL DE SAÍDAS: R$ {saidas.Sum(m => m.Valor):F2}\n");

                   
                    sw.WriteLine("=== TOTAL POR DIA ===");
                    var porDia = movimentacoes
                        .GroupBy(m => m.Data.Date)
                        .OrderBy(g => g.Key);

                    foreach (var dia in porDia)
                    {
                        decimal totalDia = dia.Sum(m => m.Valor);
                        sw.WriteLine($"{dia.Key:dd/MM/yyyy} - Total: R$ {totalDia:F2}");
                    }

                    sw.WriteLine("\n---------------------------------------------");

                   
                    sw.WriteLine($"TOTAL GERAL DO CAIXA: R$ {movimentacoes.Sum(m => m.Valor):F2}");
                }

                MessageBox.Show("Relatório gerado com sucesso!");
            }
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        {
            LimparMovimentacoesAntesDeSair();
            Application.Exit();
        }

    }

        private void menuMovimentacoes_Click(object sender, EventArgs e)
        {

        }
    }
}
