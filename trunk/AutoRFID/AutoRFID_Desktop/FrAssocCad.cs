using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fachada.Basicas;

namespace AutoRFID_Desktop
{
    public partial class FrAssocCad : AutoRFID_Desktop.frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private Associado objAssociado;

        public FrAssocCad()
        {
            InitializeComponent();
           
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
          
        }

        private void boxTipo_TextChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text.Equals("Pessoa Física")){
                cpfcnpj.Tag  = "2";
                cpfcnpj.Mask = "999,999,999-99";
            }
            else 
            {
                cpfcnpj.Tag = "3";
                cpfcnpj.Mask = @"99,9999,999/9999-99";

            }


                
            
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objAssociado = new Associado();

            cpfcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            this.objAssociado.Cpf_cnpj = cpfcnpj.Text;
            this.objAssociado.Nome_razaosocial = textNome.Text;
            try
            {
                objFachada.InserirAssociado(this.objAssociado);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Campo inválido", ex.Message);
            }
           
            //MessageBox.Show("Inclusão efetuada com sucesso!");

        }
    }
}
