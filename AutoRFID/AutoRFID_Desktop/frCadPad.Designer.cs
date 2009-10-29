namespace AutoRFID_Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadPad));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.panelConsulta = new System.Windows.Forms.GroupBox();
            this.btnPesquisarTexto = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelManutencao = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlBotoes.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSair.Image = global::AutoRFID_Desktop.Properties.Resources.format_indent_less;
            resources.ApplyResources(this.btSair, "btSair");
            this.btSair.Name = "btSair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btConfirmar, "btConfirmar");
            this.btConfirmar.Image = global::AutoRFID_Desktop.Properties.Resources.document_save;
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisar.Image = global::AutoRFID_Desktop.Properties.Resources.system_search;
            resources.ApplyResources(this.btPesquisar, "btPesquisar");
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btCancelar, "btCancelar");
            this.btCancelar.Image = global::AutoRFID_Desktop.Properties.Resources.view_refresh;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Image = global::AutoRFID_Desktop.Properties.Resources.mail_mark_not_junk;
            resources.ApplyResources(this.btExcluir, "btExcluir");
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
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
            this.btAlterar.Image = global::AutoRFID_Desktop.Properties.Resources.format_justify_right;
            resources.ApplyResources(this.btAlterar, "btAlterar");
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.btnPesquisarTexto);
            this.panelConsulta.Controls.Add(this.txtPesquisa);
            this.panelConsulta.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panelConsulta, "panelConsulta");
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.TabStop = false;
            // 
            // btnPesquisarTexto
            // 
            this.btnPesquisarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarTexto.Image = global::AutoRFID_Desktop.Properties.Resources.system_search;
            resources.ApplyResources(this.btnPesquisarTexto, "btnPesquisarTexto");
            this.btnPesquisarTexto.Name = "btnPesquisarTexto";
            this.btnPesquisarTexto.UseVisualStyleBackColor = true;
            this.btnPesquisarTexto.Click += new System.EventHandler(this.btnPesquisarTexto_Click);
            // 
            // txtPesquisa
            // 
            resources.ApplyResources(this.txtPesquisa, "txtPesquisa");
            this.txtPesquisa.Name = "txtPesquisa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // panelManutencao
            // 
            resources.ApplyResources(this.panelManutencao, "panelManutencao");
            this.panelManutencao.Name = "panelManutencao";
            this.panelManutencao.TabStop = false;
            this.panelManutencao.Enter += new System.EventHandler(this.panelManutencao_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frCadPad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSair;
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panelConsulta);
            this.Controls.Add(this.panelManutencao);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frCadPad";
            this.Load += new System.EventHandler(this.frCadPad_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frCadPad_KeyPress);
            this.pnlBotoes.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        protected System.Windows.Forms.GroupBox panelConsulta;
        protected System.Windows.Forms.GroupBox panelManutencao;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Button btnPesquisarTexto;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}