using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace TPFinalNivel3_DuarteJurczyszyn
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar(); 
            dgvArticulos.DataBind();
        }
        protected void dgvArticulos_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            var Id = dgvArticulos.SelectedDataKey.Value.ToString();
            Response.Redirect("Detalle.aspx?Id=" + Id);
        }
    }
}