using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class VehiculoU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClVehiculoUs objVehcL = new ClVehiculoUs();
                List<ClVehiculoEntidad> listaPersonal = objVehcL.mtdVehicu();
                string Json = JsonConvert.SerializeObject(listaPersonal, Newtonsoft.Json.Formatting.Indented);
                ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);
            }
        }
    }
}