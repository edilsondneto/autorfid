using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GravaMovDebito.Ticket
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autorfidDataSet.movdebitos' table. You can move, or remove it, as needed.
            this.movdebitosTableAdapter.Fill(this.autorfidDataSet.movdebitos);

            this.reportViewer1.RefreshReport();
        }
    }
}
