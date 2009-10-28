using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fachada.Basicas;
using Fachada.Fachada;


namespace AutoRFID_Desktop
{
    public partial class FrAssocCad : AutoRFID_Desktop.frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private Associado objAssociado;
        private Associado objConsulta;
        
        public FrAssocCad()
        {
            InitializeComponent();
                      
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            boxTipo.Focus();
        }

        private void boxTipo_TextChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text.Equals("Pessoa Física")){
                cpfcnpj.Tag  = "2";
                cpfcnpj.Mask = "999,999,999-99";
            }
            else 
            {
                cpfcnpj.Tag = "3";
                cpfcnpj.Mask = @"99,999,999/9999-99";

            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {   
           
            
            //verificar se a pré-validação no form cadastro foi efetuada com sucesso
            if (!base.validacaoMSG.Equals("ok"))
            {
                MessageBox.Show(base.validacaoMSG, "Atenção!");
                return;
            }

            try
            {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objAssociado = new Associado();


            try//se for alteração
            {
              int idAssoc = int.Parse(this.textCodigo.Text);
              if (idAssoc > 0)
              {
                  this.objAssociado.Idassociado = idAssoc;
              }
            }
            catch
            { }

            //tirar mascara do campo
            cpfcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            this.objAssociado.Cpf_cnpj = cpfcnpj.Text;
            this.objAssociado.Nome_razaosocial = textNome.Text;
            this.objAssociado.Tipo_pf_pj = boxTipo.SelectedIndex.ToString();
            this.objAssociado.Endereco = endereco.Text;
            try
            {
                this.objAssociado.Numero = int.Parse(numero.Text);
            }
            catch (Exception ex) { }
            this.objAssociado.Bairro = bairro.Text;
            this.objAssociado.Cidade = cidade.Text;
            this.objAssociado.Estado = estado.Text;

            try
            {
                //tirar mascara do campo
                cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                this.objAssociado.Cep = cep.Text;
            }
            catch (Exception ex) { }
            this.objAssociado.Email = email.Text;

            try
            {
                //tirar mascara do campo
                fone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                this.objAssociado.Fone = fone.Text;
            }
            catch (Exception ex) { }

            try
            {
                //tirar mascara do campo
                fonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                this.objAssociado.Fonecel = fonecelular.Text;
            }
            catch (Exception ex) { }


            if (this.objAssociado.Idassociado.Equals(0))
            {
                this.objFachada.InserirAssociado(this.objAssociado);
                this.CarregarCampos(0, "");
            }
            else
            {
                this.objFachada.AlterarAssociado(this.objAssociado);
            }

              base.habilita();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Atenção! Registro não foi gravado.");
            }

            
          
        }
    

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarCampos(int idAssoc, String cpf_cnpj)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objAssociado = new Associado();

            this.objAssociado.Idassociado = idAssoc;
            this.objAssociado.Cpf_cnpj  = cpf_cnpj;

            if (idAssoc > 0)
            {
              this.objAssociado = this.objFachada.ConsultarAssociado(idAssoc);
            }
            else if (cpf_cnpj.Length > 0)
            {
                this.objAssociado = this.objFachada.ConsultarAssociado(cpf_cnpj);
            }
            else
            {
                this.objAssociado = this.objFachada.ConsultarAssociado();
            }
              

            //Preencher campos do form
            this.textCodigo.Text = this.objAssociado.Idassociado.ToString();
            try
            {
                this.boxTipo.SelectedIndex = int.Parse(this.objAssociado.Tipo_pf_pj);
            }
            catch (Exception ex) { }
            this.cpfcnpj.Text = this.objAssociado.Cpf_cnpj;
            this.textNome.Text = this.objAssociado.Nome_razaosocial;
            this.endereco.Text = this.objAssociado.Endereco;
            this.numero.Text = this.objAssociado.Numero.ToString();
            this.bairro.Text = this.objAssociado.Bairro;
            this.cidade.Text = this.objAssociado.Cidade;
            this.estado.Text = this.objAssociado.Estado;
            this.cep.Text = this.objAssociado.Cep;
            this.email.Text = this.objAssociado.Email;
            this.fone.Text = this.objAssociado.Fone;
            this.fonecelular.Text = this.objAssociado.Fonecel;
        }

        private void FrAssocCad_Load(object sender, EventArgs e)
        {
            this.CarregarCampos(0,"");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            try
            {
                int idAssoc = int.Parse(this.textCodigo.Text);
                this.objFachada.ExcluirAssociado(idAssoc);
                this.CarregarCampos(0,"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro. "+ex.Message,"Atenção!");
            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisar();

        }

        protected override void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           int idAsso = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
           this.CarregarCampos(idAsso,"");
        }

        protected override void preencheListaCamposFiltro()
        {
            this.lCamposFiltros = new List<CampoBD>();

            CampoBD campoCod = new CampoBD("IDASSOCIADO", "Código", true, 60);
            CampoBD campoNome = new CampoBD("NOME_RAZAOSOCIAL", "Nome do Associado", true, 200);
            CampoBD campoCPF = new CampoBD("CPF_CNPJ", "CPF-CNPJ", true, 100);

            this.lCamposFiltros.Add(campoCod);
            this.lCamposFiltros.Add(campoNome);
            this.lCamposFiltros.Add(campoCPF);
        }

        private void pesquisar()
        {
            DataSet dsAssociado = new DataSet();
            dsAssociado = this.objFachada.ListarAssociado(sFiltro, lCamposFiltros);


            DataTableReader dtr = new DataTableReader(dsAssociado.Tables[0]);

            DataTable dtAssoc = new DataTable();

            dtAssoc.Load(dtr, LoadOption.OverwriteChanges);

            this.dataGridView1.DataSource = dtAssoc;

        }

        private void btnPesquisarTexto_Click(object sender, EventArgs e)
        {
            this.pesquisar();
        }



     }
}
