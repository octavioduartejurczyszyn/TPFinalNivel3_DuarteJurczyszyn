using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using System.Xml.Linq;

namespace TPFinalNivel3_DuarteJurczyszyn
{
    public partial class ModificarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var Id = Request.QueryString != null ? Request.QueryString["Id"].ToString() : "";
            try
            {
                if (!IsPostBack)
                {
                    ElementoNegocio negocio = new ElementoNegocio();
                    List<Elemento> lista = negocio.listar();

                    ddlTipo.DataSource = lista;
                    ddlTipo.DataValueField = "Id";
                    ddlTipo.DataTextField = "Descripcion";
                    ddlTipo.DataBind();

                    ddlDebilidad.DataSource = lista;
                    ddlDebilidad.DataValueField = "Id";
                    ddlDebilidad.DataTextField = "Descripcion";
                    ddlDebilidad.DataBind();
                }
                if (Id != "")
                {
                    DetalleNegocio detalleNegocio = new DetalleNegocio();
                    Articulo seleccionado = (detalleNegocio.listar(Id))[0];

                    txtCodigo.Text = seleccionado.Codigo;
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    ddlMarca.Text = seleccionado.Marca.Descripcion;
                    ddlCategoria.Text = seleccionado.Categoria.Descripcion;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}