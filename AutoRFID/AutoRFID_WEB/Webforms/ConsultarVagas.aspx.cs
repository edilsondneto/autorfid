using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Fachada.Basicas;

namespace AutoRFID_WEB.Webforms
{
    public partial class ConsultarVagas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estabelecimento est = Fachada.Fachada.Fachada.ObterFachada().ConsultarEstabelecimento(Convert.ToInt32(this.DropDownList1.SelectedValue));
            this.Lblendereco.Text = est.Endereco;
            this.Lblcidade.Text = est.Cidade;
            this.Lblbairro.Text = est.Bairro;
            this.lblquantvagas.Text = est.QtdVagas.ToString();
            this.lblvagasocupadas.Text = est.QtdVagasOcupadas.ToString();
            this.lbltotaldisponivel.Text = (est.QtdVagas - est.QtdVagasOcupadas).ToString();
        }

        protected void DropDownList1_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownList1.DataTextField = "razaosocial";
                this.DropDownList1.DataValueField = "idEstabelecimento";
                this.DropDownList1.DataSource = Fachada.Fachada.Fachada.ObterFachada().ListarEstabelecimento();
                this.DropDownList1.DataBind();
                Estabelecimento est = Fachada.Fachada.Fachada.ObterFachada().ConsultarEstabelecimento(Convert.ToInt32(this.DropDownList1.SelectedValue));
                this.Lblendereco.Text = est.Endereco;
                this.Lblcidade.Text = est.Cidade;
                this.Lblbairro.Text = est.Bairro;
                this.lblquantvagas.Text = est.QtdVagas.ToString();
                this.lblvagasocupadas.Text = est.QtdVagasOcupadas.ToString();
                this.lbltotaldisponivel.Text = (est.QtdVagas - est.QtdVagasOcupadas).ToString();
            }
        }
    }
}
