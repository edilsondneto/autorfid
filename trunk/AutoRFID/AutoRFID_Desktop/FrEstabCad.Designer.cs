namespace AutoRFID_Desktop
{
    partial class FrEstabCad
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
            this.cnpj = new System.Windows.Forms.MaskedTextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.lblNUmero = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.textRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazãoSocial = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.maskedTextCep = new System.Windows.Forms.MaskedTextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fone = new System.Windows.Forms.MaskedTextBox();
            this.fonecelular = new System.Windows.Forms.MaskedTextBox();
            this.pnlBotoes.SuspendLayout();
            this.panelManutencao.SuspendLayout();
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
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(745, 30);
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.textRazaoSocial);
            this.panelManutencao.Controls.Add(this.fonecelular);
            this.panelManutencao.Controls.Add(this.fone);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.Controls.Add(this.label1);
            this.panelManutencao.Controls.Add(this.maskedTextCep);
            this.panelManutencao.Controls.Add(this.comboEstado);
            this.panelManutencao.Controls.Add(this.cnpj);
            this.panelManutencao.Controls.Add(this.textQuantidade);
            this.panelManutencao.Controls.Add(this.lblQuantidade);
            this.panelManutencao.Controls.Add(this.lblCep);
            this.panelManutencao.Controls.Add(this.textEmail);
            this.panelManutencao.Controls.Add(this.lblEmail);
            this.panelManutencao.Controls.Add(this.lblEstado);
            this.panelManutencao.Controls.Add(this.textNumero);
            this.panelManutencao.Controls.Add(this.lblNUmero);
            this.panelManutencao.Controls.Add(this.textCidade);
            this.panelManutencao.Controls.Add(this.lblCidade);
            this.panelManutencao.Controls.Add(this.textBairro);
            this.panelManutencao.Controls.Add(this.lblBairro);
            this.panelManutencao.Controls.Add(this.textEndereco);
            this.panelManutencao.Controls.Add(this.lblEndereco);
            this.panelManutencao.Controls.Add(this.lblRazãoSocial);
            this.panelManutencao.Controls.Add(this.lblCnpj);
            this.panelManutencao.Size = new System.Drawing.Size(745, 278);
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(11, 35);
            this.cnpj.Mask = "00,000,000/0000-00";
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(111, 20);
            this.cnpj.TabIndex = 76;
            this.cnpj.Tag = "3";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(631, 142);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(88, 20);
            this.textQuantidade.TabIndex = 87;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(637, 126);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidade.TabIndex = 72;
            this.lblQuantidade.Text = "Qtde.Vagas:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(340, 126);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(29, 13);
            this.lblCep.TabIndex = 70;
            this.lblCep.Text = "Cep:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(423, 142);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(196, 20);
            this.textEmail.TabIndex = 86;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(420, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(666, 73);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 67;
            this.lblEstado.Text = "Estado:";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(640, 35);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(84, 20);
            this.textNumero.TabIndex = 79;
            // 
            // lblNUmero
            // 
            this.lblNUmero.AutoSize = true;
            this.lblNUmero.Location = new System.Drawing.Point(637, 19);
            this.lblNUmero.Name = "lblNUmero";
            this.lblNUmero.Size = new System.Drawing.Size(47, 13);
            this.lblNUmero.TabIndex = 64;
            this.lblNUmero.Text = "Número:";
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(343, 89);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(307, 20);
            this.textCidade.TabIndex = 81;
            this.textCidade.Tag = "1";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(340, 73);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 62;
            this.lblCidade.Text = "Cidade:";
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(11, 89);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(320, 20);
            this.textBairro.TabIndex = 80;
            this.textBairro.Tag = "1";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 73);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 60;
            this.lblBairro.Text = "Bairro:";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(337, 35);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(297, 20);
            this.textEndereco.TabIndex = 78;
            this.textEndereco.Tag = "1";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(335, 19);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 58;
            this.lblEndereco.Text = "Endereço:";
            // 
            // textRazaoSocial
            // 
            this.textRazaoSocial.Location = new System.Drawing.Point(131, 35);
            this.textRazaoSocial.Name = "textRazaoSocial";
            this.textRazaoSocial.Size = new System.Drawing.Size(200, 20);
            this.textRazaoSocial.TabIndex = 77;
            this.textRazaoSocial.Tag = "1";
            // 
            // lblRazãoSocial
            // 
            this.lblRazãoSocial.AutoSize = true;
            this.lblRazãoSocial.Location = new System.Drawing.Point(128, 19);
            this.lblRazãoSocial.Name = "lblRazãoSocial";
            this.lblRazãoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazãoSocial.TabIndex = 56;
            this.lblRazãoSocial.Text = "Razão Social:";
            this.lblRazãoSocial.Click += new System.EventHandler(this.lblRazãoSocial_Click);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(8, 19);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(31, 13);
            this.lblCnpj.TabIndex = 55;
            this.lblCnpj.Text = "Cnpj:";
            // 
            // maskedTextCep
            // 
            this.maskedTextCep.Location = new System.Drawing.Point(338, 142);
            this.maskedTextCep.Mask = "00000-999";
            this.maskedTextCep.Name = "maskedTextCep";
            this.maskedTextCep.Size = new System.Drawing.Size(73, 20);
            this.maskedTextCep.TabIndex = 85;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownHeight = 86;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.IntegralHeight = false;
            this.comboEstado.Items.AddRange(new object[] {
            "  ",
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.comboEstado.Location = new System.Drawing.Point(669, 88);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(53, 21);
            this.comboEstado.Sorted = true;
            this.comboEstado.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Fone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Celular";
            // 
            // fone
            // 
            this.fone.Location = new System.Drawing.Point(10, 142);
            this.fone.Mask = "(99) 0000-0000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(140, 20);
            this.fone.TabIndex = 83;
            // 
            // fonecelular
            // 
            this.fonecelular.Location = new System.Drawing.Point(156, 142);
            this.fonecelular.Mask = "(99) 0000-0000";
            this.fonecelular.Name = "fonecelular";
            this.fonecelular.Size = new System.Drawing.Size(175, 20);
            this.fonecelular.TabIndex = 84;
            // 
            // FrEstabCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 278);
            this.Name = "FrEstabCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Estabelecimento ";
            this.Load += new System.EventHandler(this.FrEstabCad_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cnpj;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label lblNUmero;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox textRazaoSocial;
        private System.Windows.Forms.Label lblRazãoSocial;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox maskedTextCep;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox fone;
        private System.Windows.Forms.MaskedTextBox fonecelular;
    }
}
