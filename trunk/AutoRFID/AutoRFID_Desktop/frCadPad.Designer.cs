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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btSair.Image = global::CamadaGui.Properties.Resources.format_indent_less;
            resources.ApplyResources(this.btSair, "btSair");
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
            this.btAlterar.Image = global::CamadaGui.Properties.Resources.format_justify_right;
            resources.ApplyResources(this.btAlterar, "btAlterar");
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panelConsulta, "panelConsulta");
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigo
            // 
            resources.ApplyResources(this.codigo, "codigo");
            this.codigo.Name = "codigo";
            // 
            // descricao
            // 
            resources.ApplyResources(this.descricao, "descricao");
            this.descricao.Name = "descricao";
            // 
            // panelManutencao
            // 
            resources.ApplyResources(this.panelManutencao, "panelManutencao");
            this.panelManutencao.Name = "panelManutencao";
            this.panelManutencao.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frCadPad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.panelManutencao);
            this.Controls.Add(this.panelConsulta);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frCadPad";
            this.Load += new System.EventHandler(this.frCadPad_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frCadPad_KeyPress);
            this.pnlBotoes.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}