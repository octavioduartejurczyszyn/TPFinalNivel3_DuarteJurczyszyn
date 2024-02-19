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
            txtId.Enabled = false;
            try
            {
                if (!IsPostBack && Id != null)
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
                if (Id != "" && !IsPostBack)
                {
                    ArticuloNegocio detalleArticulo = new ArticuloNegocio();
                    Articulo seleccionado = (detalleArticulo.listar(Id))[0];

                    Session.Add("articuloSeleccionado", seleccionado);

                    txtId.Text = seleccionado.Id.ToString();
                    txtCodigo.Text = seleccionado.Codigo;
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    ddlMarca.SelectedValue = seleccionado.Marca.Descripcion;
                    ddlCategoria.SelectedValue = seleccionado.Categoria.Descripcion;
                    txtImagenUrl.Text = seleccionado.ImagenUrl;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                }
                if (txtImagenUrl.Text != "" && txtImagenUrl.Text != null)
                {
                    imgArticulo.ImageUrl = txtImagenUrl.Text;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            var Id = Request.QueryString["Id"].ToString();

            AccesoDatos datos = new AccesoDatos();
            try
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                Articulo nuevo = new Articulo();

                nuevo.Id = int.Parse(Id);
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = new Marca();
                nuevo.Marca.Id = int.Parse(ddlMarca.SelectedValue);
                nuevo.Categoria = new Categoria();
                nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                nuevo.ImagenUrl = txtImagenUrl.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);

                articulo.modificarArticulo(nuevo);
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
        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            imgArticulo.ImageUrl = txtImagenUrl.Text;
        }
    }
}