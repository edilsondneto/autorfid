namespace CamadaGUI
{
    partial class FrCadPad
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
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(232, 5);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btConfirmar.Size = new System.Drawing.Size(72, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(310, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(553, 5);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(391, 5);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 5;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(472, 5);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(151, 5);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btConfirmar);
            this.pnlBotoes.Controls.Add(this.btPesquisar);
            this.pnlBotoes.Controls.Add(this.btCancelar);
            this.pnlBotoes.Controls.Add(this.btExcluir);
            this.pnlBotoes.Controls.Add(this.btIncluir);
            this.pnlBotoes.Controls.Add(this.btAlterar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 414);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(637, 30);
            this.pnlBotoes.TabIndex = 8;
            // 
            // FrCadPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 444);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "FrCadPad";
            this.Text = "Cadastro ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Panel pnlBotoes;


    }
}

