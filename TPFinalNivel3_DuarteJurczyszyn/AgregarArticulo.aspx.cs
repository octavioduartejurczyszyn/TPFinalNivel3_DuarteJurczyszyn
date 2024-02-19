using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3_DuarteJurczyszyn
{
    public partial class AgregarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MarcaNegocio negocioMarca = new MarcaNegocio();
                CategoriaNegocio negocioCategoria = new CategoriaNegocio();

                List<Marca> listaMarca = negocioMarca.listaMarca();
                List<Categoria> listaCategoria = negocioCategoria.listaCategoria();
                ddlMarca.DataSource = listaMarca;
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataBind();

                ddlCategoria.DataSource = listaCategoria;
                ddlCategoria.DataValueField = "Id";
                ddlCategoria.DataTextField = "Descripcion";
                ddlCategoria.DataBind();
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();


            {
                Articulo nuevo = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    nuevo.Codigo = txtCodigo.Text;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Descripcion = txtDescripcion.Text;
                    nuevo.Marca = new Marca();
                    nuevo.Marca.Id = int.Parse(ddlMarca.SelectedValue);
                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                    nuevo.ImagenUrl = txtImagenUrl.Text;
                    nuevo.Precio = decimal.Parse(txtPrecio.Text);

                    negocio.agregar(nuevo);
                    Response.Redirect("Administrador.aspx");
                    //datos.setearConsulta("insert into Articulos values('" + nuevo.Codigo + "', '', '', 1, 1, '',1)");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            imgArticulo.ImageUrl = txtImagenUrl.Text;
        }
    }
}