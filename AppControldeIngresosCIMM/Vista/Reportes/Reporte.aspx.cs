using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Obtener los datos de la variable de sesión
                DataTable dtPersonal = (DataTable)Session["ReporteProductos"];

                // Crear y configurar el objeto ReportDataSource
                ReportDataSource rds = new ReportDataSource("DataSet1", dtPersonal);
                rds.Name = "DataSet1"; // Nombre del conjunto de datos en el informe
                rds.Value = dtPersonal;

                // Configurar el ReportViewer
                RpPersonal.LocalReport.DataSources.Clear();
                RpPersonal.LocalReport.DataSources.Add(rds);
                RpPersonal.LocalReport.ReportPath = Server.MapPath("Report1.rdlc"); // Ruta del informe (.rdlc)

                // Establecer el valor del parámetro "Total" en el informe
                //ReportParameter totalParam = new ReportParameter("Total", total.ToString());
                //RpPersonal.LocalReport.SetParameters(totalParam);

                // Actualizar el ReportViewer
                RpPersonal.DataBind();
                RpPersonal.Visible = true;
            }

        }
    }
}