using System;
using System.Windows.Forms;
using Fachada.Basicas;

namespace AutoRFID_Desktop
{
    public partial class FrVenda : frCadPad
    {
        private string sAcao;

        public FrVenda()
        {
            InitializeComponent();
        }

        private void FrVenda_Load(object sender, EventArgs e)
        {
          //  this.CarregarCampos(null, null);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.sAcao = "I";
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.sAcao = "A";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esta movimentação?", "Confirmar", MessageBoxButtons.YesNoCancel) == DialogResult.OK)
            {
                Fachada.Fachada.Fachada.ObterFachada().ExcluirMovCredito(int.Parse(idMovimento.Text));
                this.CarregarCampos(null);
            }
        }
        private void CarregarCampos(string idMov)
        {
  /*          this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objMovCredito = new MovCredito();
            try
            {
                List<MovCredito> l = this.objFachada.ListarMovCredito();
                if (idFunc == null)
                {
                    this.objMovCredito = l[l.Count - 1];
                }
                else
                {
                    this.objMovCredito = this.objFachada.ConsultarFuncionario(int.Parse(idMov));
                }
            }
            catch (Exception ex) { }
            this.objFuncionario.Cpf = cpfFunc;

            this.objFuncionario = this.objFachada.ConsultarFuncionario(this.objFuncionario.Idfuncionario);

            //Preencher campos do form
            this.idFuncionario.Text = this.objMovCredito.Funcionario.Idfuncionario.ToString();
            try
            {
                this.boxTipo.Text = this.objFuncionario.Funcao;
            }
            catch (Exception ex) { }
            this.maskedTextBox5.Text = this.objFuncionario.Cpf;
            this.textNome.Text = this.objFuncionario.Nome;
            this.textBox2.Text = this.objFuncionario.Endereco;
            this.maskedTextBox4.Text = this.objFuncionario.Numero.ToString();
            this.textBox4.Text = this.objFuncionario.Bairro;
            this.textBox5.Text = this.objFuncionario.Cidade;
            this.comboBox1.Text = this.objFuncionario.Estado;
            this.maskedTextBox1.Text = this.objFuncionario.Cep;
            this.textBox7.Text = this.objFuncionario.Email;
            this.maskedTextBox2.Text = this.objFuncionario.Fone;
            this.maskedTextBox3.Text = this.objFuncionario.Fonecelular;
            try
            {
                this.boxTipo.SelectedIndex = int.Parse(this.objFuncionario.Funcao);
            }
            catch { this.boxTipo.SelectedIndex = 0; }
   */ 
        }
    
    }
    
}
