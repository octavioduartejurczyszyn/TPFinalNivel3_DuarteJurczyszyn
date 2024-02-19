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
            if (Session["admin"] != null && Session["admin"].ToString() == "admin")
            {
                if (!IsPostBack)
                {
                    repRepetidor.DataSource = negocio.listar();
                    repRepetidor.DataBind();
                }
            }
            else
                Response.Redirect("Login.aspx");
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string Id = ((Button)sender).CommandArgument;
            Response.Redirect("ModificarArticulo.aspx?Id=" + Id);

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            AccesoDatos datos = new AccesoDatos();
            string Id = ((Button)sender).CommandArgument;
            try
            {
                negocio.eliminar(int.Parse(Id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}