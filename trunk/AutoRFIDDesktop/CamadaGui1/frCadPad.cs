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


        //Abilitar botões e text
        private void habilita(bool estado)
        {
            //Estado dos botões.
            this.btIncluir.Enabled = estado;
            this.btAlterar.Enabled = estado;
            this.btExcluir.Enabled = estado;
            this.btCancelar.Enabled = !estado;
            this.btConfirmar.Enabled = !estado;
            this.btSair.Enabled = estado;
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

  
    }
}
