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
        private string sAcao;

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
            this.PreencherCmbSitucao();
            PreencherCmbAssociado();
            CarregarCampos(null);
            

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
            this.cmbAssociado.DisplayMember = "nome_razaosocial";
            this.cmbAssociado.ValueMember = "idAssociado";
            this.cmbAssociado.DataSource = Fachada.Fachada.Fachada.ObterFachada().ListarAssociado().Tables[0].DefaultView;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.sAcao = "";
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
                this.cmbAssociado.SelectedText = this.objEtiquetaAssociado.Associado.Nome_razaosocial;
                this.cmbSituacao.SelectedText = this.objEtiquetaAssociado.Situacao;
            }
            catch (Exception ex) { }

            txtCodigo.Text = objEtiquetaAssociado.CodigoEtiqueta;
            txtSaldo.Text = objEtiquetaAssociado.Saldo.ToString();
            txtValor.Text = objEtiquetaAssociado.Valor.ToString();
            
            
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.sAcao = "I";
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
                objEtiquetaAssociado.CodigoEtiqueta = this.txtCodigo.Text;
                objEtiquetaAssociado.Associado.Idassociado = Convert.ToInt32(cmbAssociado.SelectedValue);
                try
                {
                    objEtiquetaAssociado.Saldo = Convert.ToDecimal(txtSaldo.Text);
                }
                catch { objEtiquetaAssociado.Saldo = 0m; }
                objEtiquetaAssociado.Situacao = cmbSituacao.SelectedValue.ToString();
                try
                {
                    objEtiquetaAssociado.Valor = Convert.ToDecimal(txtValor.Text);
                }
                catch { objEtiquetaAssociado.Valor = 0m; }
            }

            try
            {
                this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
                //this.objEtiquetaAssociado = new EtiquetaAssociado();

                if (this.sAcao == "A")
                {
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
                }
                if (sAcao == "I")
                {
                    this.objFachada.IncluirEtiquetaAssociado(objEtiquetaAssociado);
                    this.CarregarCampos(null);
                }

                sAcao = "";
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

        protected override void preencheListaCamposFiltro()
        {
            this.lCamposFiltros = new List<CampoBD>();

            CampoBD campoCod = new CampoBD("codigo_etiqueta", "Código Etiqueta", true, 60);
            CampoBD campoNome = new CampoBD("idassociado", "Associado", true, 200);
            CampoBD campoCPF = new CampoBD("saldo", "saldo", true, 100);
            CampoBD campo2 = new CampoBD("situacao", "Situação", true, 100);

            this.lCamposFiltros.Add(campoCod);
            this.lCamposFiltros.Add(campoNome);
            this.lCamposFiltros.Add(campoCPF);
            this.lCamposFiltros.Add(campo2);
        }

        private void pesquisar()
        {
            DataSet ds = this.objFachada.ListarEtiquetaAssociado(this.sFiltro, this.lCamposFiltros);

            DataTableReader dtr = new DataTableReader(ds.Tables[0]);

            DataTable dt = new DataTable();

            dt.Load(dtr, LoadOption.OverwriteChanges);

            this.dataGridView1.DataSource = dt;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.sAcao = "A";
        }

        private void btnPesquisarTexto_Click(object sender, EventArgs e)
        {
            this.pesquisar();
        }







    }
}
