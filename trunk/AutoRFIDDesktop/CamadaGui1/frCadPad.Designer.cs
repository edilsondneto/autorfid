namespace CamadaGui1
{
    partial class frCadPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadPad));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotoes.Controls.Add(this.btConfirmar);
            this.pnlBotoes.Controls.Add(this.btPesquisar);
            this.pnlBotoes.Controls.Add(this.btCancelar);
            this.pnlBotoes.Controls.Add(this.btExcluir);
            this.pnlBotoes.Controls.Add(this.btIncluir);
            this.pnlBotoes.Controls.Add(this.btAlterar);
            resources.ApplyResources(this.pnlBotoes, "pnlBotoes");
            this.pnlBotoes.Name = "pnlBotoes";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btConfirmar, "btConfirmar");
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btPesquisar, "btPesquisar");
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btCancelar, "btCancelar");
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btExcluir, "btExcluir");
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btIncluir, "btIncluir");
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btAlterar, "btAlterar");
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // frCadPad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBotoes);
            this.Name = "frCadPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btConfirmar;
        protected System.Windows.Forms.Button btPesquisar;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btIncluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Panel pnlBotoes;
    }
}