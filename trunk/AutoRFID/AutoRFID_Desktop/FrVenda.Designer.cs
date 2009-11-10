namespace AutoRFID_Desktop
{
    partial class FrVenda
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
            this.cbEtiqueta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtCompra = new System.Windows.Forms.MaskedTextBox();
            this.dtCredito = new System.Windows.Forms.MaskedTextBox();
            this.cbEstab = new System.Windows.Forms.ComboBox();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.cbAssoc = new System.Windows.Forms.ComboBox();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.idMovimento = new System.Windows.Forms.Label();
            this.valorCreditado = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(537, 3);
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(424, 3);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(113, 3);
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Visible = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(753, 30);
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.valorCreditado);
            this.panelManutencao.Controls.Add(this.idMovimento);
            this.panelManutencao.Controls.Add(this.cbPagamento);
            this.panelManutencao.Controls.Add(this.cbAssoc);
            this.panelManutencao.Controls.Add(this.cbFunc);
            this.panelManutencao.Controls.Add(this.cbEstab);
            this.panelManutencao.Controls.Add(this.dtCompra);
            this.panelManutencao.Controls.Add(this.dtCredito);
            this.panelManutencao.Controls.Add(this.label9);
            this.panelManutencao.Controls.Add(this.label8);
            this.panelManutencao.Controls.Add(this.label7);
            this.panelManutencao.Controls.Add(this.label6);
            this.panelManutencao.Controls.Add(this.label5);
            this.panelManutencao.Controls.Add(this.label4);
            this.panelManutencao.Controls.Add(this.label3);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.Controls.Add(this.label1);
            this.panelManutencao.Controls.Add(this.cbEtiqueta);
            this.panelManutencao.Size = new System.Drawing.Size(753, 278);
            this.panelManutencao.Enter += new System.EventHandler(this.panelManutencao_Enter);
            // 
            // btnPesquisarTexto
            // 
            this.btnPesquisarTexto.Click += new System.EventHandler(this.btnPesquisarTexto_Click);
            // 
            // cbEtiqueta
            // 
            this.cbEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiqueta.FormattingEnabled = true;
            this.cbEtiqueta.Location = new System.Drawing.Point(150, 84);
            this.cbEtiqueta.Name = "cbEtiqueta";
            this.cbEtiqueta.Size = new System.Drawing.Size(121, 21);
            this.cbEtiqueta.TabIndex = 4;
            this.cbEtiqueta.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movimentação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estabelecimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Associado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etiqueta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Crédito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Forma de pagamento";
            // 
            // dtCompra
            // 
            this.dtCompra.Location = new System.Drawing.Point(295, 129);
            this.dtCompra.Mask = "00/00/0000";
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(118, 20);
            this.dtCompra.TabIndex = 8;
            this.dtCompra.Tag = "1";
            this.dtCompra.ValidatingType = typeof(System.DateTime);
            // 
            // dtCredito
            // 
            this.dtCredito.Location = new System.Drawing.Point(150, 129);
            this.dtCredito.Mask = "00/00/0000";
            this.dtCredito.Name = "dtCredito";
            this.dtCredito.Size = new System.Drawing.Size(118, 20);
            this.dtCredito.TabIndex = 7;
            this.dtCredito.Tag = "1";
            this.dtCredito.ValidatingType = typeof(System.DateTime);
            // 
            // cbEstab
            // 
            this.cbEstab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstab.FormattingEnabled = true;
            this.cbEstab.Location = new System.Drawing.Point(298, 38);
            this.cbEstab.Name = "cbEstab";
            this.cbEstab.Size = new System.Drawing.Size(121, 21);
            this.cbEstab.TabIndex = 2;
            this.cbEstab.Tag = "1";
            // 
            // cbFunc
            // 
            this.cbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Location = new System.Drawing.Point(153, 37);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(121, 21);
            this.cbFunc.TabIndex = 1;
            this.cbFunc.Tag = "1";
            // 
            // cbAssoc
            // 
            this.cbAssoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssoc.FormattingEnabled = true;
            this.cbAssoc.Location = new System.Drawing.Point(16, 85);
            this.cbAssoc.Name = "cbAssoc";
            this.cbAssoc.Size = new System.Drawing.Size(121, 21);
            this.cbAssoc.TabIndex = 3;
            this.cbAssoc.Tag = "1";
            // 
            // cbPagamento
            // 
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "CAIXA",
            "BOLETO"});
            this.cbPagamento.Location = new System.Drawing.Point(16, 129);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbPagamento.TabIndex = 6;
            this.cbPagamento.Tag = "1";
            this.cbPagamento.SelectedIndexChanged += new System.EventHandler(this.cbPagamento_SelectedIndexChanged);
            // 
            // idMovimento
            // 
            this.idMovimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idMovimento.Location = new System.Drawing.Point(20, 39);
            this.idMovimento.Name = "idMovimento";
            this.idMovimento.Size = new System.Drawing.Size(105, 21);
            this.idMovimento.TabIndex = 18;
            // 
            // valorCreditado
            // 
            this.valorCreditado.Location = new System.Drawing.Point(298, 87);
            this.valorCreditado.Name = "valorCreditado";
            this.valorCreditado.Size = new System.Drawing.Size(121, 20);
            this.valorCreditado.TabIndex = 5;
            this.valorCreditado.Tag = "1";
            this.valorCreditado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorCreditado.Leave += new System.EventHandler(this.valorCreditado_Leave);
            this.valorCreditado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorCreditado_KeyPress);
            this.valorCreditado.Enter += new System.EventHandler(this.valorCreditado_Enter);
            // 
            // FrVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(753, 278);
            this.Name = "FrVenda";
            this.Text = "Vendas de crédito";
            this.Load += new System.EventHandler(this.FrVenda_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox dtCompra;
        private System.Windows.Forms.MaskedTextBox dtCredito;
        private System.Windows.Forms.ComboBox cbAssoc;
        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.ComboBox cbEstab;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.Label idMovimento;
        private System.Windows.Forms.TextBox valorCreditado;

    }
}
