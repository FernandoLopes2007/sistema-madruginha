using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa_madruga.Movimentação
{
    public partial class frnMovimentacao : Form
    {
        public frnMovimentacao()
        {
            InitializeComponent();
        }
        public enum TipoMovimento { Entrada = 1, Saida = 2 }

        public class Movimento
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public string Descricao { get; set; }
            public TipoMovimento Tipo { get; set; }
            public decimal Valor { get; set; }
            public string FormaPagamento { get; set; }
        }

        public partial class FrmMovimentacao : Form
        {
            private readonly TipoMovimento _tipo;

            public FrmMovimentacao(TipoMovimento tipo)
            {
                InitializeComponent();
                _tipo = tipo;

                cmbFormaPagamento.Items.AddRange(new[] { "Dinheiro", "Pix", "Cartão" });
                cmbFormaPagamento.SelectedIndex = 0;

                dtData.Value = DateTime.Now;
            }
        }



        private void frnMovimentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
