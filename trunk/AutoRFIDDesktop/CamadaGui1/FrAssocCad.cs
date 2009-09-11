using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamadaGui1
{
    public partial class FrAssocCad : CamadaGui1.frCadPad
    {
        public FrAssocCad()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            this.panelConsulta.Visible = true;
            this.panelManutencao.Visible = false;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.panelConsulta.Visible = false;
            this.panelManutencao.Visible = true;
            this.habilita(true);
            this.textCodigo.Clear();
            this.textNome.Clear();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.panelConsulta.Visible = false;
            this.panelManutencao.Visible = true;
            this.habilita(true);

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.panelConsulta.Visible = false;
            this.panelManutencao.Visible = true;
        }


        //text
        private void habilita(bool estado)
        {
            this.panelManutencao.Enabled = estado;
 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.habilita(false);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            this.habilita(false);
        }

    }
}
