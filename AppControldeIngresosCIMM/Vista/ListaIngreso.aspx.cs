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
    public partial class ListaIngreso : System.Web.UI.Page
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
            List<ClPersonalE> listaPersonal = objPersonal.mtdListar();
            gvLista.DataSource = listaPersonal;
            gvLista.DataBind();


        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string tipoPer = ddlRol.SelectedValue;
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> ListaPersonal = objPersonal.mtdBuscar(tipoPer, "");
            gvLista.DataSource = ListaPersonal;
            gvLista.DataBind();
            Session["Personal"] = ListaPersonal;
        }

        protected void btnBuscarFicha_Click(object sender, EventArgs e)
        {
            string ficha = txtFicha.Text;
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> ListaPersonal = objPersonal.mtdBuscar("", ficha);
            gvLista.DataSource = ListaPersonal;
            gvLista.DataBind();
            Session["Personal"] = ListaPersonal;

        }

        protected void BtnGenerarInforme_Click(object sender, EventArgs e)
        {
            // Obtener los datos de la variable de sesión
            List<ClPersonalE> listaProd = (List<ClPersonalE>)Session["Personal"];

            //Convertir los datos a DataTable si es necesario
            DataTable dtProductos = ConvertirTabla(listaProd);

            // Almacenar los datos en una variable de sesión (opcional)
            Session["ReporteProductos"] = dtProductos;

            // Redireccionar a la página de informe
            Response.Redirect("Reportes/Reporte.aspx");
        }
        public DataTable ConvertirTabla(List<ClPersonalE> lista)
        {
            DataTable dataTable = new DataTable();

            // Agregar las columnas al DataTable y deben estar deifinidos de la misma manera que estan en el informe
            dataTable.Columns.Add("Documento", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("Telefono", typeof(string));
            dataTable.Columns.Add("Correo", typeof(string));
            dataTable.Columns.Add("Nombre_Programa", typeof(string));
            dataTable.Columns.Add("Ficha", typeof(string));
            dataTable.Columns.Add("Rol", typeof(string));



            // Agregar los datos a las filas del DataTable
            for (int i = 0; i < lista.Count; i++)
            {
                ClPersonalE producto = lista[i];
                //el metodo FirsOrDefaul se usa para buscar el primer elemento de la lista que cumpla
                dataTable.Rows.Add(
                    producto.Documento,
                    producto.Nombre,
                    producto.Apellido,
                    producto.Telefono,
                    producto.Correo,
                    producto.Programa,
                    producto.Ficha,
                    producto.Rol);
            }

            return dataTable;
        }

        protected void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> listaPersonal = objPersonal.mtdListar();
            gvLista.DataSource = listaPersonal;
            gvLista.DataBind();
            Session["Personal"] = listaPersonal;
        }
    }
}
