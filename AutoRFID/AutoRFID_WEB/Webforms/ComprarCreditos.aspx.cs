using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachada.Fachada;

namespace AutoRFID_WEB.Webforms
{
    public partial class ComprarCreditos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.NomeAssociado.Text = (string)Session["user"];
            this.DropDownList1.DataTextField = "codigo_etiqueta";
            this.DropDownList1.DataValueField = "codigo_etiqueta";
          //  this.DropDownList1.DataSource = Fachada.Fachada.Fachada.ObterFachada().ListarEtiquetasIdAssociado(1).Tables["lista"].DefaultView;
            this.DropDownList1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string x = this.TextBox1.Text;
            Session["valor"] = x;
            Response.Redirect("bancodobrasil.aspx");
        }
    }
}
