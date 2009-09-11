using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CamadaGui1
{
    public partial class frCadPad : Form
    {
        public frCadPad()
        {

            InitializeComponent();

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void frCadPad_Load(object sender, EventArgs e)
        {

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {

            this.habilita(false);
        }


        //habilitar botões
        private void habilita(bool estado)
        {
            //Estado dos botões.
            this.btIncluir.Enabled = estado;
            this.btAlterar.Enabled = estado;
            this.btExcluir.Enabled = estado;
            this.btCancelar.Enabled = !estado;
            this.btConfirmar.Enabled = !estado;
            this.btSair.Enabled = estado;
            this.btPesquisar.Enabled = estado;

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            this.habilita(false);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.habilita(true);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            this.habilita(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
