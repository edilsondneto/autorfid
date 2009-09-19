using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoRFID_Desktop
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
            //limpar campos
            this.limparCampos();
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

                if (campo is MaskedTextBox)
                {
                    if (((MaskedTextBox)campo).Tag != null)
                    {
                        if (((MaskedTextBox)campo).Tag.Equals("2"))
                        {
                            if(!ValidaCPF(campo.Text))
                            {
                                MessageBox.Show("Campo Cpf inválido!");
                                return;
                            }
                        }
                        else if (((MaskedTextBox)campo).Tag.Equals("3"))
                        {
                            if (!ValidaCNPJ(campo.Text))
                            {
                                MessageBox.Show("Campo CNPJ inválido!");
                                return;
                            }
                        }
                                                   
                    }
                }
            }
            
            this.habilita();
        }

   
    
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btExcluir_Click(object sender, EventArgs e)
        {
            //limpar campos
            this.limparCampos();
            
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

        public static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "").Replace(",", "").Trim();

            if (string.IsNullOrEmpty(valor))
                return false;

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;

            return true;
        }

        public static bool ValidaCNPJ(string vrCNPJ)
        {
            string CNPJ = vrCNPJ.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");

            if (string.IsNullOrEmpty(CNPJ))
                return false;

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(
                        CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] *
                          int.Parse(ftmt.Substring(
                          nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] *
                          int.Parse(ftmt.Substring(
                          nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (
                         resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == 0);
                    else
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == (
                        11 - resultado[nrDig]));
                }
                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
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
        
    }
}
