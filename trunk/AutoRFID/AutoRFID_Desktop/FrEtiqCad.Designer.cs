namespace AutoRFID_Desktop
{
    partial class FrEtiqCad
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.panelManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIncluir
            // 
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(749, 30);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Location = new System.Drawing.Point(7, 6);
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.textBox2);
            this.panelManutencao.Controls.Add(this.label5);
            this.panelManutencao.Controls.Add(this.textBox1);
            this.panelManutencao.Controls.Add(this.label4);
            this.panelManutencao.Controls.Add(this.label1);
            this.panelManutencao.Controls.Add(this.boxTipo);
            this.panelManutencao.Controls.Add(this.textNome);
            this.panelManutencao.Controls.Add(this.label3);
            this.panelManutencao.Controls.Add(this.textCodigo);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.Location = new System.Drawing.Point(5, 5);
            this.panelManutencao.Enter += new System.EventHandler(this.panelManutencao_Enter);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(111, 35);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(503, 20);
            this.textNome.TabIndex = 66;
            this.textNome.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Associado";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(5, 35);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 64;
            this.textCodigo.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Código *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Situação Atual *";
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Disponível",
            "Vinculada",
            "Defeito"});
            this.boxTipo.Location = new System.Drawing.Point(8, 84);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(156, 21);
            this.boxTipo.TabIndex = 79;
            this.boxTipo.Tag = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 82;
            this.textBox1.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Valor R$";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 84;
            this.textBox2.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Saldo Disponível R$";
            // 
            // FrEtiqCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 278);
            this.Name = "FrEtiqCad";
            this.Text = "Manutenção Etiqueta";
            this.pnlBotoes.ResumeLayout(false);
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}
