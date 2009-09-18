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
            this.Visible = false;
            FrTelaLogin frTelaLogin = new FrTelaLogin();
            frTelaLogin.ShowDialog();
            this.Visible = true;
         
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 0;

        }

        private void MnCadastro_Click(object sender, EventArgs e)
        {

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

        private void sobreAutoRFIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrSobreAutoRFID frSobre = new FrSobreAutoRFID();
            frSobre.ShowDialog();
        }
        



 
    }
}
