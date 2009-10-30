using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace GravaMovDebito
{
    public class SerialC
    {
        private SerialPort sp;
        private static bool status = true;
        private TextBox logbox;

        public SerialC()
        {
            this.sp = new SerialPort();
        }

        public SerialC(TextBox tb)
        {
            this.sp = new SerialPort();
            this.logbox = tb;
        }

        public List<String> ListarOpcoesPortas()
        {
            List<String> list = new List<String>();

            foreach (String port in SerialPort.GetPortNames())
            {
                String x = port;
                list.Add(x);
            }
            return list;
        }

        public List<String> ListarOpcoesParity()
        {
            List<String> list = new List<String>();

            foreach (String s in Enum.GetNames(typeof(Parity)))
            {
                String x = s;
                list.Add(x);
            }
            return list;
        }

        public List<String> ListarOpcoesStopBits()
        {
            List<String> list = new List<String>();

            foreach (String s in Enum.GetNames(typeof(StopBits)))
            {
                String x = s;
                list.Add(x);
            }
            return list;
        }

        public List<String> ListarOpcoesHandshake()
        {
            List<String> list = new List<String>();

            foreach (String s in Enum.GetNames(typeof(Handshake)))
            {
                String x = s;
                list.Add(x);
            }
            return list;
        }

        public Parity Parity
        {
            get { return this.sp.Parity; }
            set { try { this.sp.Parity = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public int BaudRate
        {
            get { return this.sp.BaudRate; }
            set { try { this.sp.BaudRate = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public String NomePorta
        {
            get { return this.sp.PortName; }
            set { try { this.sp.PortName = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public int DataBits
        {
            get { return this.sp.DataBits; }
            set { try { this.sp.DataBits = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public StopBits Stopbits
        {
            get { return this.sp.StopBits; }
            set { try { this.sp.StopBits = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public Handshake Handshake
        {
            get { return this.sp.Handshake; }
            set { try { this.sp.Handshake = value; } catch (Exception e) { throw new Exception("Erro na Porta Serial!-->" + e); } }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private delegate void SetTextCallback(String text);

        private void SetText(String text)
        {

            if (this.logbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.logbox.Invoke(d, new object[] { text });
            }
            else
            {
                this.logbox.Text = text;
            }
        }

         public void Read3()
        {
            this.sp.Open();
            
            while (status)
            {
                try
                {
                    string codigo = sp.ReadExisting();

                    if (codigo != "")
                    {
                        String x = codigo.Substring(1, codigo.Length - 2);
                        this.SetText(x);
                        codigo = "";
                    }
                    
                }
                catch (TimeoutException)
                {

                }
                Thread.Sleep(500);
            }

            this.sp.Close();
            
        }
             
    }
}
