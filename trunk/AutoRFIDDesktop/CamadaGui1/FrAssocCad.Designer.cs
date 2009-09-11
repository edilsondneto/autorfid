namespace CamadaGui1
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
            this.panelManutencao = new System.Windows.Forms.GroupBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelConsulta = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.panelManutencao.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btIncluir
            // 
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(748, 30);
            // 
            // btSair
            // 
            this.btSair.Enabled = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.textBox1);
            this.panelManutencao.Controls.Add(this.label4);
            this.panelManutencao.Controls.Add(this.textNome);
            this.panelManutencao.Controls.Add(this.label3);
            this.panelManutencao.Controls.Add(this.label1);
            this.panelManutencao.Controls.Add(this.boxTipo);
            this.panelManutencao.Controls.Add(this.textCodigo);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.Enabled = false;
            this.panelManutencao.Location = new System.Drawing.Point(4, 6);
            this.panelManutencao.Name = "panelManutencao";
            this.panelManutencao.Size = new System.Drawing.Size(732, 240);
            this.panelManutencao.TabIndex = 14;
            this.panelManutencao.TabStop = false;
            this.panelManutencao.Text = "Manutenção de Associados";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(347, 34);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(376, 20);
            this.textNome.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome Contato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo";
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.boxTipo.Location = new System.Drawing.Point(114, 34);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(121, 21);
            this.boxTipo.TabIndex = 20;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(8, 34);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código";
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.dataGridView1);
            this.panelConsulta.Location = new System.Drawing.Point(4, 6);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(729, 240);
            this.panelConsulta.TabIndex = 15;
            this.panelConsulta.TabStop = false;
            this.panelConsulta.Text = "Consulta";
            this.panelConsulta.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 220);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 580;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPF";
            // 
            // FrAssocCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 278);
            this.Controls.Add(this.panelManutencao);
            this.Controls.Add(this.panelConsulta);
            this.MaximizeBox = false;
            this.Name = "FrAssocCad";
            this.Controls.SetChildIndex(this.panelConsulta, 0);
            this.Controls.SetChildIndex(this.panelManutencao, 0);
            this.Controls.SetChildIndex(this.pnlBotoes, 0);
            this.pnlBotoes.ResumeLayout(false);
            this.panelManutencao.ResumeLayout(false);
            this.panelManutencao.PerformLayout();
            this.panelConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelManutencao;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox panelConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;

    }
}
