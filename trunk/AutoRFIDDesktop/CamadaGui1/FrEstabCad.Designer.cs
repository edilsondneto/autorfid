namespace CamadaGui1
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
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(745, 30);
            // 
            // FrEstabCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 278);
            this.Name = "FrEstabCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
