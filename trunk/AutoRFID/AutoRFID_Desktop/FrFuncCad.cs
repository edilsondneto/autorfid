using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoRFID_Desktop
{
    public partial class FrFuncCad : AutoRFID_Desktop.frCadPad
    {
        public FrFuncCad()
        {
            InitializeComponent();
        }

        private void maskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string cpf = (sender as MaskedTextBox).Text;

            try
            {
                foto.Load(@"C:\autorfid\trunk\AutoRFIDDesktop\CamadaGui1\Resources\" + cpf + ".bmp");
                foto.Visible = true;
            }
            catch
            {
                foto.Visible = false;
            }
                

        }

             
    }
}
