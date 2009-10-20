using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fachada.Basicas;
using System.Collections;

namespace AutoRFID_Desktop
{
    public partial class FrEtiqAssociado : AutoRFID_Desktop.frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private EtiquetaAssociado objEtiquetaAssociado;
        private EtiquetaAssociado objConsulta;

        public FrEtiqAssociado()
        {
            InitializeComponent();
            //cmbSituacao.DataBindings

        }


        private void FrEtiqAssociado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autorfidDataSet.associado' table. You can move, or remove it, as needed.
            objFachada = Fachada.Fachada.Fachada.ObterFachada();
            objEtiquetaAssociado = new EtiquetaAssociado();
            //this.associadoTableAdapter.Fill(this.autorfidDataSet.associado);
            CarregarCampos(null);
            this.PreencherCmbSitucao();
            PreencherCmbAssociado();
            

        }

        public void PreencherCmbSitucao()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descricao"));
            dt.Columns.Add(new DataColumn("Valor"));
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0][0] = "Ativo";
            dt.Rows[0][1] = "0";
            dt.Rows[1][0] = "Inativo";
            dt.Rows[1][1] = "1";

            cmbSituacao.DataSource = dt;
            cmbSituacao.DisplayMember = "Descricao";
            cmbSituacao.ValueMember = "Valor";
        }

        public void PreencherCmbAssociado()
        {
            //this.cmbAssociado.Tex = (string)Session["user"];
            this.cmbAssociado.DisplayMember = "nome_razaosocial";
            this.cmbAssociado.ValueMember = "idAssociado";
            this.cmbAssociado.DataSource = Fachada.Fachada.Fachada.ObterFachada().ListarAssociado().Tables[0].DefaultView;
            //this.cmbAssociado.b;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarCampos(String codigo)
        {
            this.objEtiquetaAssociado = new EtiquetaAssociado();

            try
            {
                this.objEtiquetaAssociado.CodigoEtiqueta= codigo;
            }
            catch (Exception ex) { }
            //this.objAssociado.Cpf_cnpj = cpf_cnpj;

            this.objEtiquetaAssociado = this.objFachada.ConsultarEtiquetaAssociado(this.objEtiquetaAssociado.CodigoEtiqueta);

            //Preencher campos do form
            this.txtCodigo.Text = this.objEtiquetaAssociado.CodigoEtiqueta;

            try
            {
                this.cmbAssociado.SelectedIndex = int.Parse(this.objEtiquetaAssociado.CodigoEtiqueta);
                this.cmbSituacao.SelectedIndex = int.Parse(this.objEtiquetaAssociado.Situacao);
            }
            catch (Exception ex) { }

            txtCodigo.Text = objEtiquetaAssociado.CodigoEtiqueta;
            txtSaldo.Text = objEtiquetaAssociado.Saldo.ToString();
            txtValor.Text = objEtiquetaAssociado.Valor.ToString();
            
            
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {


            //verificar se a pré-validação no form cadastro foi efetuada com sucesso
            if (!base.validacaoMSG.Equals("ok"))
            {
                MessageBox.Show(base.validacaoMSG, "Atenção!");
                return;
            }
            else
            {
                objEtiquetaAssociado.Associado.Idassociado = Convert.ToInt32(cmbAssociado.SelectedValue);
                objEtiquetaAssociado.Saldo = Convert.ToDecimal(txtSaldo.Text);
                objEtiquetaAssociado.Situacao = cmbSituacao.SelectedValue.ToString();
                objEtiquetaAssociado.Valor = Convert.ToDecimal(txtValor.Text);
            }

            try
            {
                this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
                //this.objEtiquetaAssociado = new EtiquetaAssociado();


                try//se for alteração
                {
                    string codigo = this.txtCodigo.Text;
                    objConsulta = new EtiquetaAssociado();
                    objConsulta.CodigoEtiqueta = codigo;
                    objConsulta = objFachada.ConsultarEtiquetaAssociado(objConsulta.CodigoEtiqueta);

                    if (!string.IsNullOrEmpty(objConsulta.CodigoEtiqueta))
                    {
                        this.objEtiquetaAssociado.CodigoEtiqueta = codigo;
                        objFachada.AlterarEtiquetaAssociado(objEtiquetaAssociado);
                        return;
                    }
                }
                catch
                { }

                    this.objFachada.IncluirEtiquetaAssociado(objEtiquetaAssociado);
                    this.CarregarCampos(null);
                

                base.habilita();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção! Registro não foi gravado.");
            }

        }

       


        protected override void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String idConsulta = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CarregarCampos(idConsulta);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                objFachada.ExcluirEtiquetaAssociado(codigo);
                CarregarCampos(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro. " + ex.Message, "Atenção!");
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = objFachada.ListarEtiquetaAssociado().Tables[0];
            DataSet dsAssociado = new DataSet();
            dsAssociado = this.objFachada.ListarEtiquetaAssociado();


            DataTableReader dtr = new DataTableReader(dsAssociado.Tables[0]);

            DataTable dtAssoc = new DataTable();

            dtAssoc.Load(dtr, LoadOption.OverwriteChanges);

            this.dataGridView1.DataSource = dtAssoc;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
                txtCodigo.Focus();    
          
        }







    }
}
