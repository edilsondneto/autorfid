using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Fachada.Fachada;
using Fachada.Basicas;

namespace AutoRFID_WEB.Webforms
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                Alert.Show("Cadastro Efetuado");
                Associado a = new Associado();
                a.Cpf_cnpj = this.txtCnpj.Text;
                a.Nome_razaosocial = this.txtNome.Text;
                a.Endereco = this.txtEndereco.Text;
                a.Numero = Convert.ToInt32(this.txtNumero.Text);
                a.Bairro = this.txtBairro.Text;
                a.Cidade = this.TextCidade.Text;
                a.Cep = this.txtCep.Text;
                a.Fone = this.txtFone.Text;
                a.Fonecel = this.txtCelular.Text;
                a.Email = this.txtEmail.Text;
                Fachada.Fachada.Fachada.ObterFachada().InserirAssociado(a);
                Response.Redirect("/WebForms/Principal.aspx");
            }
        }

        public bool validaCampos()
        {

            if (!Uteis.ValidaCNPJ(txtCnpj.Text) && rbtPesJur.Checked)
            {
                Alert.Show("Cnpj não é valido");
                return false;
            }

            /*if (string.IsNullOrEmpty(txtCpf.Text))
            {
                Alert.Show("Campo cpf não preenchido");
                return false;
            }

            if (!Uteis.ValidaCPF(txtCpf.Text))
            {
                Alert.Show("Cpf não é válido");
                return false;
            }*/

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Alert.Show("Campo nome não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                Alert.Show("Campo endereço não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                Alert.Show("Campo bairro não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                Alert.Show("Campo celular não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtCep.Text))
            {
                Alert.Show("Campo cep não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Alert.Show("Campo email não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtFone.Text))
            {
                Alert.Show("Campo fone não preenchido");
                return false;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                Alert.Show("Campo número não preenchido");
                return false;
            }

            return true;
        }

        public void preencherEntidade()
        { }

        protected void rbtPesFis_CheckedChanged(object sender, EventArgs e)
        {
            mask1.Mask = "999,999,999-99";
            MaskedEditValidator1.ValidationExpression = @"\d{3}\.\d{3}\.\d{3}\-\d{2}";
            
        }

        protected void rbtPesJur_CheckedChanged(object sender, EventArgs e)
        {
            mask1.Mask = "99,999,999/9999-99";
            MaskedEditValidator1.ValidationExpression = @"\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}";
        }


    }
}
