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
            boxTipo.Focus();
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

            //tirar mascara do campo
            cpfcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            this.objAssociado.Cpf_cnpj = cpfcnpj.Text;
            this.objAssociado.Nome_razaosocial = textNome.Text;
            this.objAssociado.Tipo_pf_pj = boxTipo.SelectedIndex.ToString();
            this.objAssociado.Endereco = endereco.Text;
            this.objAssociado.Numero = int.Parse(numero.Text);
            this.objAssociado.Bairro = bairro.Text;
            this.objAssociado.Cidade = cidade.Text;
            this.objAssociado.Estado = estado.Text;
            //tirar mascara do campo
            cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objAssociado.Cep = cep.Text;
            this.objAssociado.Email = email.Text;
            //tirar mascara do campo
            fone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objAssociado.Fone = fone.Text;
            //tirar mascara do campo
            fonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objAssociado.Fonecel = fonecelular.Text;

            try
            {
                objFachada.InserirAssociado(this.objAssociado);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Atenção!");
            }

            //AutoRFID_Desktop.frCadPad.
            //habilita();
            

          
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

     }
}
