namespace AutoRFID_Desktop
{
    partial class frMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnEstabCad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnFuncCad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnEtiqCad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAssocCad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMovVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMovBaixaTik = new System.Windows.Forms.ToolStripMenuItem();
            this.MnRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnRelOcupac = new System.Windows.Forms.ToolStripMenuItem();
            this.MnRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreAutoRFIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCadastro,
            this.MnMovimentacao,
            this.MnRelatorios,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnCadastro
            // 
            this.MnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnEstabCad,
            this.MnFuncCad,
            this.MnEtiqCad,
            this.MnAssocCad});
            this.MnCadastro.Name = "MnCadastro";
            this.MnCadastro.Size = new System.Drawing.Size(63, 20);
            this.MnCadastro.Text = "Cadastro";
            this.MnCadastro.Click += new System.EventHandler(this.MnCadastro_Click);
            // 
            // MnEstabCad
            // 
            this.MnEstabCad.Name = "MnEstabCad";
            this.MnEstabCad.Size = new System.Drawing.Size(157, 22);
            this.MnEstabCad.Text = "Estabelecimentos";
            this.MnEstabCad.Click += new System.EventHandler(this.MnEstabCad_Click);
            // 
            // MnFuncCad
            // 
            this.MnFuncCad.Name = "MnFuncCad";
            this.MnFuncCad.Size = new System.Drawing.Size(157, 22);
            this.MnFuncCad.Text = "Funcionários";
            this.MnFuncCad.Click += new System.EventHandler(this.MnFuncCad_Click);
            // 
            // MnEtiqCad
            // 
            this.MnEtiqCad.Name = "MnEtiqCad";
            this.MnEtiqCad.Size = new System.Drawing.Size(157, 22);
            this.MnEtiqCad.Text = "Etiquetas";
            this.MnEtiqCad.Click += new System.EventHandler(this.MnEtiqCad_Click);
            // 
            // MnAssocCad
            // 
            this.MnAssocCad.Name = "MnAssocCad";
            this.MnAssocCad.Size = new System.Drawing.Size(157, 22);
            this.MnAssocCad.Text = "Associado";
            this.MnAssocCad.Click += new System.EventHandler(this.MnAssocCad_Click);
            // 
            // MnMovimentacao
            // 
            this.MnMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnMovVenda,
            this.MnMovBaixaTik});
            this.MnMovimentacao.Name = "MnMovimentacao";
            this.MnMovimentacao.Size = new System.Drawing.Size(88, 20);
            this.MnMovimentacao.Text = "Movimentação";
            // 
            // MnMovVenda
            // 
            this.MnMovVenda.Name = "MnMovVenda";
            this.MnMovVenda.Size = new System.Drawing.Size(162, 22);
            this.MnMovVenda.Text = "Venda de Créditos";
            this.MnMovVenda.Click += new System.EventHandler(this.MnMovVenda_Click);
            // 
            // MnMovBaixaTik
            // 
            this.MnMovBaixaTik.Name = "MnMovBaixaTik";
            this.MnMovBaixaTik.Size = new System.Drawing.Size(162, 22);
            this.MnMovBaixaTik.Text = "Baixa de Tiket";
            // 
            // MnRelatorios
            // 
            this.MnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnRelOcupac,
            this.MnRelVendas});
            this.MnRelatorios.Name = "MnRelatorios";
            this.MnRelatorios.Size = new System.Drawing.Size(67, 20);
            this.MnRelatorios.Text = "Relatórios";
            // 
            // MnRelOcupac
            // 
            this.MnRelOcupac.Name = "MnRelOcupac";
            this.MnRelOcupac.Size = new System.Drawing.Size(122, 22);
            this.MnRelOcupac.Text = "Ocupação";
            // 
            // MnRelVendas
            // 
            this.MnRelVendas.Name = "MnRelVendas";
            this.MnRelVendas.Size = new System.Drawing.Size(122, 22);
            this.MnRelVendas.Text = "Vendas";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreAutoRFIDToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreAutoRFIDToolStripMenuItem
            // 
            this.sobreAutoRFIDToolStripMenuItem.Name = "sobreAutoRFIDToolStripMenuItem";
            this.sobreAutoRFIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreAutoRFIDToolStripMenuItem.Text = "Sobre AutoRFID";
            this.sobreAutoRFIDToolStripMenuItem.Click += new System.EventHandler(this.sobreAutoRFIDToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::AutoRFID_Desktop.Properties.Resources.RFID;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 626);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMenuPrincipal";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu AutoRFID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnCadastro;
        private System.Windows.Forms.ToolStripMenuItem MnEstabCad;
        private System.Windows.Forms.ToolStripMenuItem MnFuncCad;
        private System.Windows.Forms.ToolStripMenuItem MnEtiqCad;
        private System.Windows.Forms.ToolStripMenuItem MnAssocCad;
        private System.Windows.Forms.ToolStripMenuItem MnMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem MnMovVenda;
        private System.Windows.Forms.ToolStripMenuItem MnMovBaixaTik;
        private System.Windows.Forms.ToolStripMenuItem MnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MnRelOcupac;
        private System.Windows.Forms.ToolStripMenuItem MnRelVendas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreAutoRFIDToolStripMenuItem;



    }
}