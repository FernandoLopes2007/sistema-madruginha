using System;
using System.Linq;
using System.Windows.Forms;

namespace caixa_madruga.Movimentação
{
    public partial class frmMovimentacao : Form
    {
        public Movimentacao MovimentacaoSalva { get; private set; }


        public frmMovimentacao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("O nome do cliente não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtCliente.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O nome do cliente não pode conter números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(cmbTipo.Text))
            {
                MessageBox.Show("Selecione o tipo da movimentação (Entrada ou Saída).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (numValor.Value <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MovimentacaoSalva = new Movimentacao()
            {
                Cliente = txtCliente.Text,
                Valor = numValor.Value,
                Data = dtData.Value,
                Tipo = cmbTipo.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
