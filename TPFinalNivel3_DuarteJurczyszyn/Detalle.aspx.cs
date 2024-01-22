using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using System.Data.SqlClient;
using System.Collections;

namespace TPFinalNivel3_DuarteJurczyszyn
{
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var Id = Request.QueryString["Id"] != null ? Request.QueryString["Id"].ToString() : "";

            DetalleNegocio detalleNegocio = new DetalleNegocio();

            if (Id != "")
            {
            dgvDetalle.DataSource = detalleNegocio.listar(Id); ;
            }            
            dgvDetalle.DataBind();

        }
    }
}