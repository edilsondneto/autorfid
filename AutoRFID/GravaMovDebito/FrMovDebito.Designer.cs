namespace GravaMovDebito
{
    partial class FrMovDebito
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeEtiqueta = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "IMPRIMIR TICKET AVULSO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeEtiqueta
            // 
            this.btnLeEtiqueta.Location = new System.Drawing.Point(37, 151);
            this.btnLeEtiqueta.Name = "btnLeEtiqueta";
            this.btnLeEtiqueta.Size = new System.Drawing.Size(192, 60);
            this.btnLeEtiqueta.TabIndex = 1;
            this.btnLeEtiqueta.Text = "LÊR ETIQUETA RFID";
            this.btnLeEtiqueta.UseVisualStyleBackColor = true;
            this.btnLeEtiqueta.Click += new System.EventHandler(this.btnLeEtiqueta_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 231);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrMovDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnLeEtiqueta);
            this.Controls.Add(this.button1);
            this.Name = "FrMovDebito";
            this.Text = "FrMovDebito";
            this.Load += new System.EventHandler(this.FrMovDebito_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrMovDebito_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeEtiqueta;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox textBox1;
    }
}