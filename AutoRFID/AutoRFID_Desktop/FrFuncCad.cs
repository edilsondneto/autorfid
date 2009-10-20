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
        {
            this.objFuncionario = new Funcionario();
            this.objFuncionario.Funcao = boxTipo.SelectedIndex.ToString();
            this.objFuncionario.Estado = comboBox1.Text;

            this.maskedTextBox5.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objFuncionario.Cpf = maskedTextBox5.Text;

            this.objFuncionario.Bairro = textBox4.Text;

            this.maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objFuncionario.Cep = maskedTextBox1.Text;

            this.objFuncionario.Cidade = textBox5.Text;
            this.objFuncionario.Email = textBox7.Text;
            this.objFuncionario.Endereco = textBox2.Text;

            this.maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objFuncionario.Fone = maskedTextBox2.Text;

            this.objFuncionario.Nome = textNome.Text;

            this.maskedTextBox4.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedTextBox4.Text != "")
            {
                this.objFuncionario.Numero = int.Parse(maskedTextBox4.Text);
            }

            this.objFuncionario.Idestabelecimento = 2;

            this.maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.objFuncionario.Fonecelular = maskedTextBox3.Text;

            try
            {
                if (this.sAcao == "I")
                {
                    Fachada.Fachada.Fachada.ObterFachada().InserirFuncionario(this.objFuncionario);
                }
                else if (this.sAcao == "A")
                {
                    this.objFuncionario.Idfuncionario = int.Parse(textCodigo.Text);
                    Fachada.Fachada.Fachada.ObterFachada().AlterarFuncionario(this.objFuncionario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.sAcao = "";
            base.habilita();
            this.CarregarCampos(0, null);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.sAcao = "I";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o funcionário " + textNome.Text) == DialogResult.OK)
            {
                try
                {
                    Fachada.Fachada.Fachada.ObterFachada().ExcluirFuncionario(maskedTextBox5.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.CarregarCampos(0, null);
            }
        }

        private void CarregarCampos(int idFunc, String cpfFunc)
        {
            this.objFuncionario = new Funcionario();

            try
            {
                if (cpfFunc != null)
                {
                    this.objFuncionario = Fachada.Fachada.Fachada.ObterFachada().ConsultarFuncionario(cpfFunc);
                }
                else
                {
                    this.objFuncionario = Fachada.Fachada.Fachada.ObterFachada().ConsultarFuncionario(idFunc);
                }

                this.textCodigo.Text = this.objFuncionario.Idfuncionario.ToString();
                this.boxTipo.Text = this.objFuncionario.Funcao;
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

                if (this.objFuncionario.Funcao != null)
                {
                    this.boxTipo.SelectedIndex = int.Parse(this.objFuncionario.Funcao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrFuncCad_Load(object sender, EventArgs e)
        {
            this.CarregarCampos(0, null);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            sAcao = "A"; //Ação é alterar
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.sAcao = "";
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            try
            {
                ds = Fachada.Fachada.Fachada.ObterFachada().ListarFuncionario();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTableReader dtr = new DataTableReader(ds.Tables[0]);
            DataTable dt = new DataTable();

            dt.Load(dtr, LoadOption.OverwriteChanges);
            this.dataGridView1.DataSource = dt;
        }

        protected override void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String idConsulta = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CarregarCampos(int.Parse(idConsulta), null);
        }


    }
}
