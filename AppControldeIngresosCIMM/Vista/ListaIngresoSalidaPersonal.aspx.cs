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
    public partial class ListaIngresoSalidaPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> lista = objPersonal.mtdListarIngresoSalidaPersonal();
            gvLista.DataSource = lista;
            gvLista.DataBind();
        }
    }
}