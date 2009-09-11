using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using CamadaGUI.Login;

namespace CamadaGui1
{
    public partial class frMenuPrincipal : Form
    {
        public frMenuPrincipal()
        {
            InitializeComponent();        
        }

        private void MnEstabCad_Click(object sender, EventArgs e)
        {
            FrEstabCad frEstabCad = new FrEstabCad();
            //frEstabCad.MdiParent = this;
            frEstabCad.ShowDialog();
        }

        private void MnFuncCad_Click(object sender, EventArgs e)
        {
            FrFuncCad frFuncCad = new FrFuncCad();
            //frFuncCad.MdiParent = this;
            frFuncCad.ShowDialog();
        }

        private void MnTpFuncCad_Click(object sender, EventArgs e)
        {
            FrTpFuncCad frTpFuncCad = new FrTpFuncCad();
            //frTpFuncCad.MdiParent = this;
            frTpFuncCad.ShowDialog();

        }

        private void MnTpPagCad_Click(object sender, EventArgs e)
        {
            FrTpPagCad frTpPagCad = new FrTpPagCad();
            //frTpPagCad.MdiParent = this;
            frTpPagCad.ShowDialog();
        }

        private void MnEtiqCad_Click(object sender, EventArgs e)
        {
            FrEtiqCad frEtiqCad = new FrEtiqCad();
            //frEtiqCad.MdiParent = this;
            frEtiqCad.ShowDialog();
        }

        private void MnAssocCad_Click(object sender, EventArgs e)
        {
            FrAssocCad frAssocCad = new FrAssocCad();
            //frAssocCad.MdiParent = this;
            frAssocCad.ShowDialog();
        }

        private void MnMovVenda_Click(object sender, EventArgs e)
        {
            FrVenda frVenda = new FrVenda();
            //frVenda.MdiParent = this;
            frVenda.ShowDialog();
        }

        private void frMenuPrincipal_Load(object sender, EventArgs e)
        {
           // this.Visible = false;
           // FrTelaLogin frTelaLogin = new FrTelaLogin();
           //.. frTelaLogin.ShowDialog();
           // this.Visible = true;
        }

        private void MnCadastro_Click(object sender, EventArgs e)
        {

        }
        



 
    }
}
