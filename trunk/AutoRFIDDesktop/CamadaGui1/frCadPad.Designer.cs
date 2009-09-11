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
            this.btSair = new System.Windows.Forms.Button();
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
            this.pnlBotoes.Controls.Add(this.btSair);
            this.pnlBotoes.Controls.Add(this.btConfirmar);
            this.pnlBotoes.Controls.Add(this.btPesquisar);
            this.pnlBotoes.Controls.Add(this.btCancelar);
            this.pnlBotoes.Controls.Add(this.btExcluir);
            this.pnlBotoes.Controls.Add(this.btIncluir);
            this.pnlBotoes.Controls.Add(this.btAlterar);
            resources.ApplyResources(this.pnlBotoes, "pnlBotoes");
            this.pnlBotoes.Name = "pnlBotoes";
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btSair, "btSair");
            this.btSair.Image = global::CamadaGui.Properties.Resources.format_indent_less;
            this.btSair.Name = "btSair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btConfirmar, "btConfirmar");
            this.btConfirmar.Image = global::CamadaGui.Properties.Resources.document_save;
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisar.Image = global::CamadaGui.Properties.Resources.system_search;
            resources.ApplyResources(this.btPesquisar, "btPesquisar");
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btCancelar, "btCancelar");
            this.btCancelar.Image = global::CamadaGui.Properties.Resources.view_refresh;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Image = global::CamadaGui.Properties.Resources.mail_mark_not_junk;
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
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Image = global::CamadaGui.Properties.Resources.format_justify_right;
            resources.ApplyResources(this.btAlterar, "btAlterar");
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // frCadPad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBotoes);
            this.MinimizeBox = false;
            this.Name = "frCadPad";
            this.Load += new System.EventHandler(this.frCadPad_Load);
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
        protected System.Windows.Forms.Button btSair;
    }
}