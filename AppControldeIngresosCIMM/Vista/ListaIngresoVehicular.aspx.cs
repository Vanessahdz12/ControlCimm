using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class ListaIngresoVehicular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClRolL objRol = new ClRolL();
                List<ClRolE> listaRol = new List<ClRolE>();
                listaRol = objRol.mtdListarRol();

                ddlRol.DataSource = listaRol;
                ddlRol.DataTextField = "Rol";
                ddlRol.DataValueField = "idRol";
                ddlRol.DataBind();
                ddlRol.Items.Insert(0, new ListItem("Seleccione: ", "0"));
            }

            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> listaPersonal = objPersonal.mtdListarVehiculoPorterias();
            gvLista.DataSource = listaPersonal;
            gvLista.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipoPer = ddlRol.SelectedValue;
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> ListaPersonal = objPersonal.mtdBuscarVehiculosPorteria(tipoPer, "");
            gvLista.DataSource = ListaPersonal;
            gvLista.DataBind();
            Session["Personal"] = ListaPersonal;
        }

        public DataTable ConvertirTabla(List<ClPersonalE> lista)
        {
            DataTable dataTable = new DataTable();

            // Agregar las columnas al DataTable y deben estar deifinidos de la misma manera que estan en el informe
            dataTable.Columns.Add("Documento", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("TipoVehiculo", typeof(string));
            dataTable.Columns.Add("Marca", typeof(string));
            dataTable.Columns.Add("Placa", typeof(string));
            dataTable.Columns.Add("Fecha_Ingreso", typeof(string));
            dataTable.Columns.Add("Fecha_Salida", typeof(string));
            dataTable.Columns.Add("Rol", typeof(string));
            dataTable.Columns.Add("Tipo_Porteria", typeof(string));


            // Agregar los datos a las filas del DataTable
            for (int i = 0; i < lista.Count; i++)
            {
                ClPersonalE producto = lista[i];
                dataTable.Rows.Add(
                    producto.Documento,
                    producto.Nombre,
                    producto.Apellido,
                    producto.TipoVehiculo,
                    producto.Marca,
                    producto.Placa,
                    producto.Fecha_Ingreso,
                    producto.Fecha_Salida,
                    producto.Rol,
                    producto.Tipo_Porteria);
            }

            return dataTable;
        }

        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Obtener los datos de la variable de sesión
            List<ClPersonalE> listaPers = (List<ClPersonalE>)Session["Personal"];

            //Convertir los datos a DataTable si es necesario
            DataTable dtPersonal = ConvertirTabla(listaPers);

            // Almacenar los datos en una variable de sesión (opcional)
            Session["ReportePersonal"] = dtPersonal;

            // Redireccionar a la página de informe
            Response.Redirect("Reportes/ReporteIngresoVehicular.aspx");
        }

        protected void btnBuscarPorteria_Click(object sender, EventArgs e)
        {
            string porteria = "";
            if (RbPeatonal.Checked)
            {
                porteria = "1";
            }
            else if (RbVehicular.Checked)
            {
                porteria = "2";
            }
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> ListaPersonal = objPersonal.mtdBuscarVehiculosPorteria("", porteria);
            gvLista.DataSource = ListaPersonal;
            gvLista.DataBind();
            Session["Personal"] = ListaPersonal;
        }
    }
}