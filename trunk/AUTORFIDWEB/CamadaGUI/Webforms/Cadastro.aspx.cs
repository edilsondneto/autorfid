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

namespace CamadaGUI.Webforms
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
                limparCampos();
            }
        }

        public bool validaCampos()
        {
            //if (string.IsNullOrEmpty(txtRazaoSocial.Text))
              //  Alert.Show("teste");

            if (Uteis.ValidaCNPJ(txtCnpj.Text) && !string.IsNullOrEmpty(txtCnpj.Text))
            {
                Alert.Show("Cnpj não é valido");
                return false;
            }

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                Alert.Show("Campo cpf não preenchido");
                return false;
            }

            if (Uteis.ValidaCPF(txtCpf.Text))
            {
                Alert.Show("Cpf não é válido");
                return false;
            }

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

        public void limparCampos()
        {
            int count = 0;
            foreach(Control c in Page.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        count++;
                        
                        if (c2.Controls.GetType() == typeof(TextBox))
                        {
                            TextBox txt = (TextBox)c2.Controls[count];
                        }
                    }
                }
            }
                    
            
        }
    }
}
