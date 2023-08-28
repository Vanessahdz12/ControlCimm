using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class Registro_Articulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadAllElements();
            }
        }

        public void LoadAllElements()
        {
            ClArticuloLog objUsuEnt = new ClArticuloLog();
            var mtdGetMunicipios = objUsuEnt.mtdGetUsua();
            LoadMunicipiosToDdl(mtdGetMunicipios, ddlArticulo);
        }

        public void LoadMunicipiosToDdl(List<ClArticuloEnt> municipios, DropDownList dropDownList)
        {
            dropDownList.DataSource = municipios;
            dropDownList.DataTextField = "NombreUsua";
            dropDownList.DataValueField = "ìdUsuario"; // Cambiar "ìdUsuario" al campo correcto de ID
            dropDownList.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            ClArticuloEnt Articulo = new ClArticuloEnt();
            Articulo.NombreAr = txtNobre_Articulo.Text;
            Articulo.Descripcion = txtDescripcion.Text;
            Articulo.Cantidad = txtCantidad.Text;
            Articulo.TipoArt = txtTìpo_Articulo.Text;
            Articulo.ìdUsuario = int.Parse(ddlArticulo.SelectedValue);




            ClRegistraArticuloD objUslogic = new ClRegistraArticuloD();
            string Result = objUslogic.mtdRefgistrarArticulo(Articulo.NombreAr, Articulo.Descripcion, Articulo.Cantidad, Articulo.TipoArt, Articulo.ìdUsuario);
            string script;




            if (string.IsNullOrEmpty(Result))
            {

                string mensaje = "Se guardó exitosamente el artículo";
                script = "<script type=\"text/javascript\">alert('" + mensaje + "');</script>";

                // Limpiar los campos después de un registro exitoso
                txtNobre_Articulo.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                txtTìpo_Articulo.Text = "";


            }
            else
            {
                script = "<script type=\"text/javascript\">alert('" + Result + "');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script);
            }

            ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script);
        }
    }
}