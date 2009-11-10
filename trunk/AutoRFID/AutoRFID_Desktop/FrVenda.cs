using System;
using System.Windows.Forms;
using Fachada.Basicas;
using System.Collections.Generic;
using System.Data;

namespace AutoRFID_Desktop
{
    public partial class FrVenda : frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private MovCredito objMovCredito;
        private string sAcao;
        private Funcionario objFunc;
        public FrVenda()
        {
            InitializeComponent();
        }

        private void FrVenda_Load(object sender, EventArgs e)
        {
            this.CarregarCampos(null);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.sAcao = "I";
            this.limpar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.sAcao = "A";
        }
        private void limpar()
        {
            this.idMovimento.Text = "";
            this.cbFunc.SelectedIndex = -1;
            this.dtCompra.Clear();
            this.dtCredito.Clear();
            this.cbEstab.SelectedIndex = -1;
            this.cbAssoc.SelectedIndex = -1;
            this.cbPagamento.SelectedIndex = -1;
            this.cbEtiqueta.SelectedIndex = -1;
            this.valorCreditado.Clear();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esta movimentação?", "Confirmar", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Fachada.Fachada.Fachada.ObterFachada().ExcluirMovCredito(int.Parse(idMovimento.Text));
                this.CarregarCampos(null);
            }
        }
        private void CarregarCampos(string idMov)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objFunc = new Funcionario();
            try
            {
                cbFunc.DataSource = this.objFachada.ListarFuncionario().Tables[0];
                cbFunc.DisplayMember = "nome";
                cbFunc.ValueMember = "idfuncionario";

                cbEtiqueta.DataSource = this.objFachada.ListarEtiquetaAssociado().Tables[0];
                cbEtiqueta.DisplayMember = "codigo_etiqueta";
                cbEtiqueta.ValueMember = "codigo_etiqueta";

                cbEstab.DataSource = this.objFachada.ListarEstabelecimento().Tables[0];
                cbEstab.DisplayMember = "razaosocial";
                cbEstab.ValueMember = "idestabelecimento";

                cbAssoc.DataSource = this.objFachada.ListarAssociado().Tables[0];
                cbAssoc.DisplayMember = "nome_razaosocial";
                cbAssoc.ValueMember = "idassociado";


            }
            catch (Exception exc) { }
            this.objMovCredito = new MovCredito();
            try
            {
                List<MovCredito> lista = this.objFachada.ListarMovCredito();
                if (idMov == null)
                {
                    this.objMovCredito = lista[lista.Count - 1];
                }
                else
                {
                    this.objMovCredito = this.objFachada.ConsultarMovCredito(int.Parse(idMov));
                }
            }
            catch (Exception ex) { }
            try
            {
                this.idMovimento.Text = this.objMovCredito.IdMovCredito.ToString();
                this.cbFunc.Text = this.objMovCredito.Funcionario.Nome.ToString();
                this.dtCompra.Text = this.objMovCredito.DtCompra.ToString();
                if ((this.objMovCredito.DtCredito.Year > 1))
                {
                    this.dtCredito.Text = this.objMovCredito.DtCredito.ToString();
                    this.dtCredito.Visible = true;
                }
                else { this.dtCredito.Visible = false; }
                this.cbEstab.Text = this.objMovCredito.Estabelecimento.IdEstabelecimento.ToString();
                this.cbAssoc.Text = this.objMovCredito.Associado.Idassociado.ToString();
                this.cbPagamento.Text = this.objMovCredito.FormaPag.ToString();
                this.cbEtiqueta.Text = this.objMovCredito.Etiquetaassociado.CodigoEtiqueta.ToString();
                this.valorCreditado.Text = this.objMovCredito.VlCredito.ToString();
                this.valorCreditado.Text = Convert.ToDouble(this.valorCreditado.Text).ToString("N2");
                if (this.objMovCredito.FormaPag.ToString().Equals("B"))
                {
                    this.cbPagamento.SelectedIndex = 1;
                }
                else { this.cbPagamento.SelectedIndex = 0; }
            }
            catch (Exception ex) { }

        }

        private void panelManutencao_Enter(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!validacaoMSG.Equals("ok"))
            { MessageBox.Show(validacaoMSG, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                this.objMovCredito = new MovCredito();
                this.objMovCredito.FormaPag = cbPagamento.ValueMember.ToString();
                this.objMovCredito.Funcionario = this.objFachada.ConsultarFuncionario(int.Parse(this.cbFunc.SelectedValue.ToString()));
                this.objMovCredito.Etiquetaassociado = this.objFachada.ConsultarEtiquetaAssociado(this.cbEtiqueta.SelectedValue.ToString());
                this.objMovCredito.Estabelecimento = this.objFachada.ConsultarEstabelecimento(int.Parse(this.cbEstab.SelectedValue.ToString()));
                this.objMovCredito.Associado = this.objFachada.ConsultarAssociado(int.Parse(this.cbAssoc.SelectedValue.ToString()));
                this.objMovCredito.DtCompra = DateTime.Parse(this.dtCompra.Text);
                this.objMovCredito.VlCredito = float.Parse(this.valorCreditado.Text.ToString().Replace(',', '.'));
                if (this.cbPagamento.SelectedIndex == 0)
                {
                    this.objMovCredito.FormaPag = "C";
                    this.objMovCredito.DtCredito = DateTime.Parse(this.dtCredito.Text);
                }
                else
                {
                    this.objMovCredito.FormaPag = "B";

                }

                if (this.sAcao.Equals("I"))
                {
                    this.objFachada.InserirMovCredito(this.objMovCredito);
                }
                habilita();
            }


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.CarregarCampos(null);
        }

        private void valorCreditado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPagamento.SelectedIndex.Equals(0) || !dtCredito.Text.ToString().Trim().Equals("  /  /".Trim()))
            {
                this.dtCredito.Visible = true;
                this.label6.Visible = true;
            }
            else
            {
                this.dtCredito.Visible = false;
                this.label6.Visible = false;
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisar();
        }
        private void pesquisar()
        {
            DataSet ds = this.objFachada.ListarMovCreditoDataset(this.sFiltro, this.lCamposFiltros);

            DataTableReader dtr = new DataTableReader(ds.Tables[0]);

            DataTable dt = new DataTable();

            dt.Load(dtr, LoadOption.OverwriteChanges);

            this.dataGridView1.DataSource = dt;
        }

        private void btnPesquisarTexto_Click(object sender, EventArgs e)
        {
            this.pesquisar();
        }


        protected override void preencheListaCamposFiltro()
        {
            this.lCamposFiltros = new List<CampoBD>();

            CampoBD campoId = new CampoBD("IDMOVCREDITOS", "Código", true, 100);
            CampoBD campoEtiqueta = new CampoBD("CODIGO_ETIQUETA", "Etiqueta", true, 100);
            CampoBD campoDtCompra = new CampoBD("DTCOMPRA", "Data da compra", false, 100);
            CampoBD campoDtCredito = new CampoBD("DTCREDITO", "Data do Crédito", false, 100);
            CampoBD campoVlCreditado = new CampoBD("VALORCREDITADO", "Valor do Crédito", false, 100);


            this.lCamposFiltros.Add(campoId);
            this.lCamposFiltros.Add(campoEtiqueta);
            this.lCamposFiltros.Add(campoDtCompra);
            this.lCamposFiltros.Add(campoDtCredito);
            this.lCamposFiltros.Add(campoVlCreditado);


        }
        protected override void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String idConsulta = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CarregarCampos(idConsulta);
        }

        private void valorCreditado_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= this.valorCreditado.Text.Length - 1; i++)
            {
                if ((this.valorCreditado.Text[i] >= '0' &&
                    this.valorCreditado.Text[i] <= '9') ||
                    this.valorCreditado.Text[i] == ',')
                {
                    x += this.valorCreditado.Text[i];
                }
            }
            this.valorCreditado.Text = x;
            this.valorCreditado.SelectAll();
        }

        private void valorCreditado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                 (e.KeyChar != ',' && e.KeyChar != '.' &&
                  e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!this.valorCreditado.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void valorCreditado_Leave(object sender, EventArgs e)
        {
            this.valorCreditado.Text = Convert.ToDouble(this.valorCreditado.Text).ToString("N2");
        }

    }
}
