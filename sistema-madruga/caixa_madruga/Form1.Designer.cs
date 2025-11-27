namespace caixa_madruga
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.dgMovimentos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuMovimentações,
            this.MenuRelatórios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.MenuFuncionários});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(88, 24);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // MenuFuncionários
            // 
            this.MenuFuncionários.Name = "MenuFuncionários";
            this.MenuFuncionários.Size = new System.Drawing.Size(224, 26);
            this.MenuFuncionários.Text = "Funcionários";
            // 
            // MenuMovimentações
            // 
            this.MenuMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeCaixaToolStripMenuItem,
            this.sAaToolStripMenuItem});
            this.MenuMovimentações.Name = "MenuMovimentações";
            this.MenuMovimentações.Size = new System.Drawing.Size(128, 24);
            this.MenuMovimentações.Text = "Movimentações";
            this.MenuMovimentações.Click += new System.EventHandler(this.MenuMovimentações_Click);
            // 
            // entradaDeCaixaToolStripMenuItem
            // 
            this.entradaDeCaixaToolStripMenuItem.Name = "entradaDeCaixaToolStripMenuItem";
            this.entradaDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.entradaDeCaixaToolStripMenuItem.Text = "Entrada de caixa";
            // 
            // sAaToolStripMenuItem
            // 
            this.sAaToolStripMenuItem.Name = "sAaToolStripMenuItem";
            this.sAaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.sAaToolStripMenuItem.Text = "Saída de caixa";
            // 
            // MenuRelatórios
            // 
            this.MenuRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioToolStripMenuItem,
            this.mensalToolStripMenuItem,
            this.porFuncionárioToolStripMenuItem});
            this.MenuRelatórios.Name = "MenuRelatórios";
            this.MenuRelatórios.Size = new System.Drawing.Size(90, 24);
            this.MenuRelatórios.Text = "Relatórios";
            // 
            // diárioToolStripMenuItem
            // 
            this.diárioToolStripMenuItem.Name = "diárioToolStripMenuItem";
            this.diárioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.diárioToolStripMenuItem.Text = "Diário";
            // 
            // mensalToolStripMenuItem
            // 
            this.mensalToolStripMenuItem.Name = "mensalToolStripMenuItem";
            this.mensalToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.mensalToolStripMenuItem.Text = "Mensal";
            // 
            // porFuncionárioToolStripMenuItem
            // 
            this.porFuncionárioToolStripMenuItem.Name = "porFuncionárioToolStripMenuItem";
            this.porFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.porFuncionárioToolStripMenuItem.Text = "Por funcionário";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(48, 24);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img04
            // 
            this.img04.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.img04.Location = new System.Drawing.Point(368, 267);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(310, 195);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Location = new System.Drawing.Point(12, 267);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(310, 195);
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::caixa_madruga.Properties.Resources.download;
            this.img02.Location = new System.Drawing.Point(377, 40);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(310, 195);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 2;
            this.img02.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::caixa_madruga.Properties.Resources.dinheiro;
            this.img01.Location = new System.Drawing.Point(12, 40);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(310, 195);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // dgMovimentos
            // 
            this.dgMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovimentos.Location = new System.Drawing.Point(838, 53);
            this.dgMovimentos.Name = "dgMovimentos";
            this.dgMovimentos.RowHeadersWidth = 51;
            this.dgMovimentos.RowTemplate.Height = 24;
            this.dgMovimentos.Size = new System.Drawing.Size(240, 150);
            this.dgMovimentos.TabIndex = 5;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 499);
            this.Controls.Add(this.dgMovimentos);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentações;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionários;
        private System.Windows.Forms.ToolStripMenuItem entradaDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFuncionárioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgMovimentos;
    }
}

