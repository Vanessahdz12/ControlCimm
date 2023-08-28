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
    public partial class Historial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClHistorialLog mtdEve = new ClHistorialLog();
                List<ClHistorialEn> clEventoEs = mtdEve.mtdHistorialLog();

                gvHistorial.DataSource = clEventoEs;
                gvHistorial.DataBind();
            }
        }
    }
}