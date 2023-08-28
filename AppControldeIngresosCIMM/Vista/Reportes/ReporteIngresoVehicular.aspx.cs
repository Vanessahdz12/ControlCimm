using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista.Reportes
{
    public partial class ReporteIngresoVehicular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Obtener los datos de la variable de sesión
                DataTable dtPersonal = (DataTable)Session["ReportePersonal"];

                // Crear y configurar el objeto ReportDataSource
                ReportDataSource rds = new ReportDataSource("DataSet3", dtPersonal);
                rds.Name = "DataSet3"; // Nombre del conjunto de datos en el informe
                rds.Value = dtPersonal;

                // Configurar el ReportViewer
                RpPersonal.LocalReport.DataSources.Clear();
                RpPersonal.LocalReport.DataSources.Add(rds);
                RpPersonal.LocalReport.ReportPath = Server.MapPath("Report3.rdlc"); // Ruta del informe (.rdlc)

                // Actualizar el ReportViewer
                RpPersonal.DataBind();
                RpPersonal.Visible = true;
            }
        }
    }
}