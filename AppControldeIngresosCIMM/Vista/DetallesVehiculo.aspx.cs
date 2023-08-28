using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class DetallesVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClPersonalD objPersonal = new ClPersonalD();
            List<ClPersonalE> lista = objPersonal.mtdDetallesVehiculo();
            gvLista.DataSource = lista;
            gvLista.DataBind();

        }
    }
}