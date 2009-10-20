namespace AutoRFID_Desktop
{
    partial class FrEtiqAssociado
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbAssociado = new System.Windows.Forms.ComboBox();
            this.associadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssociado = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.pnlBotoes.SuspendLayout();
            this.panelManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.txtValor);
            this.panelManutencao.Controls.Add(this.txtSaldo);
            this.panelManutencao.Controls.Add(this.cmbSituacao);
            this.panelManutencao.Controls.Add(this.lblValor);
            this.panelManutencao.Controls.Add(this.lblSaldo);
            this.panelManutencao.Controls.Add(this.lblSituacao);
            this.panelManutencao.Controls.Add(this.lblAssociado);
            this.panelManutencao.Controls.Add(this.cmbAssociado);
            this.panelManutencao.Controls.Add(this.txtCodigo);
            this.panelManutencao.Controls.Add(this.lblCodigo);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Tag = "1";
            // 
            // cmbAssociado
            // 
            this.cmbAssociado.DataSource = this.associadoBindingSource;
            this.cmbAssociado.DisplayMember = "nome_razaosocial";
            this.cmbAssociado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssociado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbAssociado.FormattingEnabled = true;
            this.cmbAssociado.Location = new System.Drawing.Point(123, 44);
            this.cmbAssociado.Name = "cmbAssociado";
            this.cmbAssociado.Size = new System.Drawing.Size(121, 21);
            this.cmbAssociado.TabIndex = 2;
            this.cmbAssociado.Tag = "1";
            this.cmbAssociado.ValueMember = "idAssociado";
            // 
            // associadoBindingSource
            // 
            this.associadoBindingSource.DataMember = "associado";
            // 
            // lblAssociado
            // 
            this.lblAssociado.AutoSize = true;
            this.lblAssociado.Location = new System.Drawing.Point(120, 24);
            this.lblAssociado.Name = "lblAssociado";
            this.lblAssociado.Size = new System.Drawing.Size(59, 13);
            this.lblAssociado.TabIndex = 3;
            this.lblAssociado.Text = "Associado:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(354, 29);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(251, 29);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(484, 29);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor:";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(357, 45);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 12;
            this.cmbSituacao.Tag = "1";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(250, 44);
            this.txtSaldo.Mask = "00000000000000000";
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PromptChar = ' ';
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(487, 45);
            this.txtValor.Mask = "000000000000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.PromptChar = ' ';
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 14;
            // 
            // FrEtiqAssociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(744, 278);
            this.Name = "FrEtiqAssociado";
            this.Text = "Etiqueta Associado";
            this.Load += new System.EventHandler(this.FrEtiqAssociado_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAssociado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAssociado;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
       
        private System.Windows.Forms.BindingSource associadoBindingSource;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.MaskedTextBox txtSaldo;
    }
}
