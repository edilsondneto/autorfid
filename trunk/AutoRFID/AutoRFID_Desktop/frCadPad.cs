using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fachada.Controlador;
namespace AutoRFID_Desktop
{
    public partial class frCadPad : Form
    {
        public String validacaoMSG;
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
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 0.3;

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {   //limpar campos
            this.limparCampos();
         
            this.habilita();
        }


        //habilitar botões
        public void habilita()
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
            //limpar campos
            //this.limparCampos();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //Validar campos
            validacaoMSG = "ok"; 
            foreach (Control campo in this.panelManutencao.Controls)
            {
                if (campo is TextBox){
                 if (((TextBox)campo).Tag != null)
                 { if (((TextBox)campo).Tag.Equals("1") & ((TextBox)campo).Text.Length.Equals(0)){

                     validacaoMSG = "Campo não pode ser branco!";
                     return;
                    
                 }
                }
                }

                if (campo is MaskedTextBox)
                {
                    if (((MaskedTextBox)campo).Tag != null)
                    {
                        if (((MaskedTextBox)campo).Tag.Equals("2"))
                        {
                            if(!Validacao.ValidaCPF(campo.Text))
                            {
                                validacaoMSG = "CPF inválido";
                                
                                return;

                            }
                        }
                        else if (((MaskedTextBox)campo).Tag.Equals("3"))
                        {
                            if (!Validacao.ValidaCNPJ(campo.Text))
                            {
                                this.validacaoMSG = "CNPJ inválido!";
                                return;
                                
                            }
                        }
                                                   
                    }
                }
            }
            
            //por conta das validações no controlador a habilitação dos botões fica na classe filha.
            //this.habilita();
        }

   
    
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //limpar campos
            //this.limparCampos();
            
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

        private void limparCampos()
        {
            foreach (Control campo in this.panelManutencao.Controls)
            {
                if (campo is TextBox)
                { ((TextBox)campo).Clear(); }
                else if (campo is MaskedTextBox)
                { ((MaskedTextBox)campo).Clear(); }

            }
        }

        private bool increase = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (increase)
                this.Opacity += 0.02D;

            if (this.Opacity == 1)
            {
                increase = false;
                //this.Close();
            }
        }

        protected virtual void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
      
        }

      
   
        
    }
}
