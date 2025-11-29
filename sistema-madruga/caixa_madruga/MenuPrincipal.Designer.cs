namespace caixa_madruga
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentacoes,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 28);
            this.menuStrip1.TabIndex = 1;
            // 
            // menuMovimentacoes
            // 
            this.menuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaMovimentacao});
            this.menuMovimentacoes.Name = "menuMovimentacoes";
            this.menuMovimentacoes.Size = new System.Drawing.Size(128, 24);
            this.menuMovimentacoes.Text = "Movimentações";
            this.menuMovimentacoes.Click += new System.EventHandler(this.menuMovimentacoes_Click);
            // 
            // menuNovaMovimentacao
            // 
            this.menuNovaMovimentacao.Name = "menuNovaMovimentacao";
            this.menuNovaMovimentacao.Size = new System.Drawing.Size(230, 26);
            this.menuNovaMovimentacao.Text = "Nova Movimentação";
            this.menuNovaMovimentacao.Click += new System.EventHandler(this.menuNovaMovimentacao_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatóriosToolStripMenuItem});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(90, 24);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // gerarRelatóriosToolStripMenuItem
            // 
            this.gerarRelatóriosToolStripMenuItem.Name = "gerarRelatóriosToolStripMenuItem";
            this.gerarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.gerarRelatóriosToolStripMenuItem.Text = "Gerar Relatórios";
            this.gerarRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatóriosToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(48, 24);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colData,
            this.colCliente,
            this.colTipo,
            this.colValor});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 394);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colData
            // 
            this.colData.Text = "Data";
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            // 
            // colValor
            // 
            this.colValor.Text = "Valor";
            // 
            // MenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(548, 501);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem menuNovaMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colValor;
    }
}
