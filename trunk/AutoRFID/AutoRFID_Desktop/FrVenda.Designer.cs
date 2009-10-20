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
            this.idMovimento = new System.Windows.Forms.TextBox();
            this.idFuncionario = new System.Windows.Forms.TextBox();
            this.idEstabelecimento = new System.Windows.Forms.TextBox();
            this.idAssociado = new System.Windows.Forms.TextBox();
            this.cbEtiqueta = new System.Windows.Forms.ComboBox();
            this.valorCreditado = new System.Windows.Forms.TextBox();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
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
            this.pnlBotoes.SuspendLayout();
            this.panelManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(537, 3);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(424, 3);
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
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(753, 30);
            // 
            // panelManutencao
            // 
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
            this.panelManutencao.Controls.Add(this.cbPagamento);
            this.panelManutencao.Controls.Add(this.valorCreditado);
            this.panelManutencao.Controls.Add(this.cbEtiqueta);
            this.panelManutencao.Controls.Add(this.idAssociado);
            this.panelManutencao.Controls.Add(this.idEstabelecimento);
            this.panelManutencao.Controls.Add(this.idFuncionario);
            this.panelManutencao.Controls.Add(this.idMovimento);
            this.panelManutencao.Size = new System.Drawing.Size(753, 278);
            // 
            // idMovimento
            // 
            this.idMovimento.Location = new System.Drawing.Point(16, 38);
            this.idMovimento.Name = "idMovimento";
            this.idMovimento.Size = new System.Drawing.Size(121, 20);
            this.idMovimento.TabIndex = 2;
            // 
            // idFuncionario
            // 
            this.idFuncionario.Location = new System.Drawing.Point(150, 38);
            this.idFuncionario.Name = "idFuncionario";
            this.idFuncionario.Size = new System.Drawing.Size(121, 20);
            this.idFuncionario.TabIndex = 3;
            // 
            // idEstabelecimento
            // 
            this.idEstabelecimento.Location = new System.Drawing.Point(286, 38);
            this.idEstabelecimento.Name = "idEstabelecimento";
            this.idEstabelecimento.Size = new System.Drawing.Size(121, 20);
            this.idEstabelecimento.TabIndex = 4;
            // 
            // idAssociado
            // 
            this.idAssociado.Location = new System.Drawing.Point(16, 85);
            this.idAssociado.Name = "idAssociado";
            this.idAssociado.Size = new System.Drawing.Size(121, 20);
            this.idAssociado.TabIndex = 5;
            // 
            // cbEtiqueta
            // 
            this.cbEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiqueta.FormattingEnabled = true;
            this.cbEtiqueta.Location = new System.Drawing.Point(150, 84);
            this.cbEtiqueta.Name = "cbEtiqueta";
            this.cbEtiqueta.Size = new System.Drawing.Size(121, 21);
            this.cbEtiqueta.TabIndex = 6;
            // 
            // valorCreditado
            // 
            this.valorCreditado.Location = new System.Drawing.Point(286, 85);
            this.valorCreditado.Name = "valorCreditado";
            this.valorCreditado.Size = new System.Drawing.Size(121, 20);
            this.valorCreditado.TabIndex = 7;
            // 
            // cbPagamento
            // 
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Location = new System.Drawing.Point(16, 129);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbPagamento.TabIndex = 8;
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
            this.label3.Location = new System.Drawing.Point(286, 22);
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
            this.label7.Location = new System.Drawing.Point(286, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 69);
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
            this.dtCompra.Location = new System.Drawing.Point(286, 129);
            this.dtCompra.Mask = "00/00/0000";
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(118, 20);
            this.dtCompra.TabIndex = 19;
            this.dtCompra.ValidatingType = typeof(System.DateTime);
            // 
            // dtCredito
            // 
            this.dtCredito.Location = new System.Drawing.Point(150, 129);
            this.dtCredito.Mask = "00/00/0000";
            this.dtCredito.Name = "dtCredito";
            this.dtCredito.Size = new System.Drawing.Size(118, 20);
            this.dtCredito.TabIndex = 18;
            this.dtCredito.ValidatingType = typeof(System.DateTime);
            // 
            // FrVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(753, 278);
            this.Name = "FrVenda";
            this.Text = "Vendas de crédito";
            this.Load += new System.EventHandler(this.FrVenda_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idMovimento;
        private System.Windows.Forms.ComboBox cbEtiqueta;
        private System.Windows.Forms.TextBox idAssociado;
        private System.Windows.Forms.TextBox idEstabelecimento;
        private System.Windows.Forms.TextBox idFuncionario;
        private System.Windows.Forms.TextBox valorCreditado;
        private System.Windows.Forms.ComboBox cbPagamento;
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

    }
}
