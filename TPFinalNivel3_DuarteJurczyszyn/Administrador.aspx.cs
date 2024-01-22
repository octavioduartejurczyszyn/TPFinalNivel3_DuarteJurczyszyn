using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace TPFinalNivel3_DuarteJurczyszyn
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (!IsPostBack)
            {
                repRepetidor.DataSource = negocio.listar();
                repRepetidor.DataBind();
            }

        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
        }
    }
}