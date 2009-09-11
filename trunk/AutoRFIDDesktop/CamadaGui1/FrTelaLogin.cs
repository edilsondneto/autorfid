using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CamadaGUI.Login
{
    public partial class FrTelaLogin : Form
    {
        public FrTelaLogin()
        {
            InitializeComponent();
        }

        private Boolean f_validaCampos()
        {
            string sVazio = "";
            string sLogin = "RFID";
            string sSenha = "1234";

            if (txbLogin.Text.Equals(sVazio))
            {
                MessageBox.Show("O Login precisa ser informado!");
                return false;
            }
            
            if (txbSenha.Text.Equals(sVazio))
            {
                MessageBox.Show("A Senha precisa ser informada!");
                return false;
            }

            if (!((txbLogin.Text.Equals(sLogin)) && (txbSenha.Text.Equals(sSenha))))
            {
                MessageBox.Show("O Login ou a Senha estão inválidos!");
                return false;
            }

            return true; 
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            if (f_validaCampos()) 
            {
                this.Close();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbLogin_Enter(object sender, EventArgs e)
        {

            validaCampo(txbLogin);
        }
        protected Boolean validaCampo(Object campo)
        {
            campo.GetType();
            return true;
        }    
    }

    
}
