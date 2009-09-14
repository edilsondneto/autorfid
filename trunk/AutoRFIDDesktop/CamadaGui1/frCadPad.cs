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
            this.panelConsulta.Visible = true;
            this.panelManutencao.Visible = false;
            this.habilita();
            this.btCancelar.Enabled = false;
            this.btConfirmar.Enabled = false;

        }

        private void frCadPad_Load(object sender, EventArgs e)
        {

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {   //limpar campos
            foreach (Control campo in this.panelManutencao.Controls)
            {
                if (campo is TextBox)
                { ((TextBox)campo).Clear(); }
                else if (campo is MaskedTextBox)
                { ((MaskedTextBox)campo).Clear(); }

            }

            this.habilita();
        }


        //habilitar botões
        private void habilita()
        {
            //Estado dos botões.
            this.btIncluir.Enabled       = !(this.btIncluir.Enabled);
            this.btAlterar.Enabled       = !(this.btAlterar.Enabled);
            this.btExcluir.Enabled       = !(this.btExcluir.Enabled);
            this.btCancelar.Enabled      = !(this.btCancelar.Enabled);
            this.btConfirmar.Enabled     = !(this.btConfirmar.Enabled);
            this.btSair.Enabled          = !(this.btSair.Enabled);
            this.btPesquisar.Enabled     = !(this.btPesquisar.Enabled);

            //Estado dos campos
            this.panelManutencao.Enabled = !(this.btIncluir.Enabled);


        }


        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.habilita();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.habilita();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //Validar campos
            foreach (Control campo in this.panelManutencao.Controls)
            {
                if (campo is TextBox){
                 if (((TextBox)campo).Tag != null)
                 { if (((TextBox)campo).Tag.Equals("1") & ((TextBox)campo).Text.Length.Equals(0)){
                    MessageBox.Show("Campo não pode ser branco!");
                    return;
                 }
                }
                }
            }
            
            this.habilita();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panelConsulta.Visible = false;
            this.panelManutencao.Visible = true;
            this.habilita();
            this.btCancelar.Enabled  = false;
            this.btConfirmar.Enabled = false;

        }

        private void frCadPad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        
    }
}
