namespace AutoRFID_Desktop
{
    partial class FrAssocCad
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
            this.cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.numero = new System.Windows.Forms.MaskedTextBox();
            this.fonecelular = new System.Windows.Forms.MaskedTextBox();
            this.fone = new System.Windows.Forms.MaskedTextBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.panelConsulta.SuspendLayout();
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
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
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
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.cpfcnpj);
            this.panelManutencao.Controls.Add(this.numero);
            this.panelManutencao.Controls.Add(this.fonecelular);
            this.panelManutencao.Controls.Add(this.fone);
            this.panelManutencao.Controls.Add(this.cep);
            this.panelManutencao.Controls.Add(this.label13);
            this.panelManutencao.Controls.Add(this.label12);
            this.panelManutencao.Controls.Add(this.email);
            this.panelManutencao.Controls.Add(this.label11);
            this.panelManutencao.Controls.Add(this.label10);
            this.panelManutencao.Controls.Add(this.estado);
            this.panelManutencao.Controls.Add(this.label9);
            this.panelManutencao.Controls.Add(this.cidade);
            this.panelManutencao.Controls.Add(this.label8);
            this.panelManutencao.Controls.Add(this.bairro);
            this.panelManutencao.Controls.Add(this.label7);
            this.panelManutencao.Controls.Add(this.label6);
            this.panelManutencao.Controls.Add(this.endereco);
            this.panelManutencao.Controls.Add(this.label5);
            this.panelManutencao.Controls.Add(this.label4);
            this.panelManutencao.Controls.Add(this.textNome);
            this.panelManutencao.Controls.Add(this.label3);
            this.panelManutencao.Controls.Add(this.label1);
            this.panelManutencao.Controls.Add(this.boxTipo);
            this.panelManutencao.Controls.Add(this.textCodigo);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.TabIndex = 0;
            // 
            // btnPesquisarTexto
            // 
            this.btnPesquisarTexto.Click += new System.EventHandler(this.btnPesquisarTexto_Click);
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.Location = new System.Drawing.Point(241, 35);
            this.cpfcnpj.Mask = "999,999,999-99";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.Size = new System.Drawing.Size(115, 20);
            this.cpfcnpj.TabIndex = 12;
            this.cpfcnpj.Tag = "2";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(347, 79);
            this.numero.Mask = "999999";
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(41, 20);
            this.numero.TabIndex = 15;
            // 
            // fonecelular
            // 
            this.fonecelular.Location = new System.Drawing.Point(540, 131);
            this.fonecelular.Mask = "(99) 0000-0000";
            this.fonecelular.Name = "fonecelular";
            this.fonecelular.Size = new System.Drawing.Size(183, 20);
            this.fonecelular.TabIndex = 22;
            // 
            // fone
            // 
            this.fone.Location = new System.Drawing.Point(394, 131);
            this.fone.Mask = "(99) 0000-0000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(140, 20);
            this.fone.TabIndex = 21;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(67, 131);
            this.cep.Mask = "00000-999";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(115, 20);
            this.cep.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Celular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Fone";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(188, 131);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 20);
            this.email.TabIndex = 20;
            this.email.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "e-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "CEP";
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
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
            this.estado.Location = new System.Drawing.Point(8, 131);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(53, 21);
            this.estado.Sorted = true;
            this.estado.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Estado";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(540, 79);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(183, 20);
            this.cidade.TabIndex = 17;
            this.cidade.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cidade";
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(394, 79);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(140, 20);
            this.bairro.TabIndex = 16;
            this.bairro.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Número";
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(8, 79);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(333, 20);
            this.endereco.TabIndex = 14;
            this.endereco.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "CPF / CNPJ *";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(362, 35);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(361, 20);
            this.textNome.TabIndex = 13;
            this.textNome.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nome / Razão Social *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo *";
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.boxTipo.Location = new System.Drawing.Point(114, 35);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(121, 21);
            this.boxTipo.TabIndex = 11;
            this.boxTipo.Tag = "1";
            this.boxTipo.TextChanged += new System.EventHandler(this.boxTipo_TextChanged);
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Location = new System.Drawing.Point(8, 35);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 10;
            this.textCodigo.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Código *";
            // 
            // FrAssocCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(744, 278);
            this.Name = "FrAssocCad";
            this.Text = "Manutenção de Associado";
            this.Load += new System.EventHandler(this.FrAssocCad_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cpfcnpj;
        private System.Windows.Forms.MaskedTextBox numero;
        private System.Windows.Forms.MaskedTextBox fonecelular;
        private System.Windows.Forms.MaskedTextBox fone;
        private System.Windows.Forms.MaskedTextBox cep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
    }
}
