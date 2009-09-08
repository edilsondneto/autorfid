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
    public partial class frMenuPrincipal : Form
    {
        public frMenuPrincipal()
        {
            InitializeComponent();        
        }

        private void MnEstabCad_Click(object sender, EventArgs e)
        {
            FrEstabCad frEstabCad = new FrEstabCad();
            frEstabCad.MdiParent = this;
            frEstabCad.Show();
        }

        private void MnFuncCad_Click(object sender, EventArgs e)
        {
            FrFuncCad frFuncCad = new FrFuncCad();
            frFuncCad.MdiParent = this;
            frFuncCad.Show();
        }

        private void MnTpFuncCad_Click(object sender, EventArgs e)
        {
            FrTpFuncCad frTpFuncCad = new FrTpFuncCad();
            frTpFuncCad.MdiParent = this;
            frTpFuncCad.Show();

        }

        private void MnTpPagCad_Click(object sender, EventArgs e)
        {
            FrTpPagCad frTpPagCad = new FrTpPagCad();
            frTpPagCad.MdiParent = this;
            frTpPagCad.Show();
        }
        



 
    }
}
