using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fachada.Basicas;
using System.Threading;

namespace GravaMovDebito
{
    public partial class FrMovDebito : Form
    {
        private Thread t;

        public FrMovDebito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MovDebito movDeb = new MovDebito();
                movDeb.Associado = new Associado();
                movDeb.Associado.Idassociado = 0;
                movDeb.IdCodigoEtiqueta = "AVULSOS";
                movDeb.Estabelecimento = new Estabelecimento { IdEstabelecimento = 4 };
                movDeb.DataEntrada = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                movDeb.HoraEntrada = DateTime.Now.ToShortTimeString();
                //movDeb.IdCodigoEtiqueta = "1";             
                Fachada.Fachada.Fachada.ObterFachada().InserirMovDebito(movDeb);
                Estabelecimento estabelecimento = Fachada.Fachada.Fachada.ObterFachada().ConsultarEstabelecimento(movDeb.Estabelecimento.IdEstabelecimento);
                estabelecimento.QtdVagasOcupadas += 1;
                Fachada.Fachada.Fachada.ObterFachada().AlterarEstabelecimento(estabelecimento);
                lblMensagem.Text = "Impressos!";

                Ticket.Ticket frTicket = new GravaMovDebito.Ticket.Ticket();
                frTicket.ShowDialog();

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }

       
        public MovDebito PreencherMovDeb(EtiquetaAssociado etiqueta)
        {
            MovDebito movDeb = new MovDebito();
            movDeb.Associado = etiqueta.Associado;
            movDeb.Estabelecimento = new Estabelecimento { IdEstabelecimento = 6 };
            movDeb.IdCodigoEtiqueta = etiqueta.CodigoEtiqueta;
            movDeb.DataEntrada = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            movDeb.HoraEntrada = DateTime.Now.ToShortTimeString();

            return movDeb;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                EtiquetaAssociado etiqueta = Fachada.Fachada.Fachada.ObterFachada().ConsultarEtiquetaAssociado(this.textBox1.Text);
                Fachada.Fachada.Fachada.ObterFachada().InserirMovDebito(PreencherMovDeb(etiqueta));
                MovDebito movDeb = new MovDebito() { Estabelecimento = new Estabelecimento() {IdEstabelecimento = 4 } };
                Estabelecimento estabelecimento = Fachada.Fachada.Fachada.ObterFachada().ConsultarEstabelecimento(movDeb.Estabelecimento.IdEstabelecimento);
                estabelecimento.QtdVagasOcupadas += 1;
               
                lblMensagem.Text = "Etiqueta válida.";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void FrMovDebito_Load(object sender, EventArgs e)
        {
            SerialC serial = new SerialC(textBox1);
            serial.NomePorta = "COM3";
            t = new Thread(new ThreadStart(serial.Read3));
            t.Start();
            
        }

        private void FrMovDebito_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
