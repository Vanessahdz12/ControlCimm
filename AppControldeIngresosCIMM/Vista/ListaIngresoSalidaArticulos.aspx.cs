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
    public partial class ListaIngresoSalidaArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Guarda = 1;
            ClGuardaD objGuarda = new ClGuardaD();
            List<ClGuardaE> lista = objGuarda.mtdListarIngresoSalida(Guarda);
            gvLista.DataSource = lista;
            gvLista.DataBind();
        }
    }
}