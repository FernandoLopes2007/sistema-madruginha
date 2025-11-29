using System;
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
    }
}
