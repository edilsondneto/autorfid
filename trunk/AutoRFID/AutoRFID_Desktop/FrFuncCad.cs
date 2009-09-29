using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fachada.Fachada;
using Fachada.Basicas;

namespace AutoRFID_Desktop
{
    public partial class FrFuncCad : AutoRFID_Desktop.frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private Funcionario objFuncionario;
        private Funcionario objConsulta;
        private string sAcao;
        
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

        private void btConfirmar_Click(object sender, EventArgs e)
        {   maskedTextBox5.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox4.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objFuncionario = new Funcionario();
            this.objFuncionario.Funcao = boxTipo.SelectedIndex.ToString();
            this.objFuncionario.Estado = comboBox1.Text;
            this.objFuncionario.Cpf = maskedTextBox5.Text;
            this.objFuncionario.Bairro = textBox4.Text;
            this.objFuncionario.Cep =maskedTextBox1.Text;
            this.objFuncionario.Cidade =textBox5.Text;
            this.objFuncionario.Email =textBox7.Text;
            this.objFuncionario.Endereco =textBox2.Text;
            this.objFuncionario.Fone =maskedTextBox2.Text;
            this.objFuncionario.Nome =textNome.Text;
            this.objFuncionario.Numero =  int.Parse(maskedTextBox4.Text);
            this.objFuncionario.Idestabelecimento = 2;
            this.objFuncionario.Fonecelular = maskedTextBox3.Text;
            
            if (this.sAcao == "I")
            {
                this.objFachada.InserirFuncionario(this.objFuncionario);
            }else if(this.sAcao == "A"){
                this.objFuncionario.Idfuncionario = int.Parse(textCodigo.Text);
                this.objFachada.AlterarFuncionario(this.objFuncionario);
            }
            this.sAcao = "";
            base.habilita();
            this.CarregarCampos(null, null);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.sAcao = "I";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir o funcionário " + textNome.Text) == DialogResult.OK)
            {
                Fachada.Fachada.Fachada.ObterFachada().ExcluirFuncionario(maskedTextBox5.Text);
                this.CarregarCampos(null, null);
            }
        }

        private void CarregarCampos(String idFunc, String cpfFunc)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objFuncionario = new Funcionario();

            try
            {
                List<Funcionario> l = this.objFachada.ListarFuncionario();
                this.objFuncionario = l[l.Count - 1];
            }
            catch (Exception ex) { }
            this.objFuncionario.Cpf = cpfFunc;

            this.objFuncionario = this.objFachada.ConsultarFuncionario(this.objFuncionario.Idfuncionario);

            //Preencher campos do form
            this.textCodigo.Text = this.objFuncionario.Idfuncionario.ToString();
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
        }

        private void FrFuncCad_Load(object sender, EventArgs e)
        {
            this.CarregarCampos(null, null);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            sAcao = "A"; //Ação é alterar
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.sAcao ="";
        }

             
    }
}
