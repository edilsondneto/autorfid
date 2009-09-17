namespace CamadaGui1
{
    partial class FrTpFuncCad
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
            this.pnlBotoes.Size = new System.Drawing.Size(746, 30);
            // 
            // panelManutencao
            // 
            this.panelManutencao.Controls.Add(this.textNome);
            this.panelManutencao.Controls.Add(this.label3);
            this.panelManutencao.Controls.Add(this.textCodigo);
            this.panelManutencao.Controls.Add(this.label2);
            this.panelManutencao.Location = new System.Drawing.Point(2, 0);
            this.panelManutencao.Size = new System.Drawing.Size(727, 244);
            this.panelManutencao.Enter += new System.EventHandler(this.panelManutencao_Enter);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(114, 37);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(503, 20);
            this.textNome.TabIndex = 58;
            this.textNome.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Função Ocupada *";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(8, 37);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 56;
            this.textCodigo.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Código *";
            // 
            // FrTpFuncCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(746, 278);
            this.Name = "FrTpFuncCad";
            this.Text = "Manutenção de Função";
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
    }
}
