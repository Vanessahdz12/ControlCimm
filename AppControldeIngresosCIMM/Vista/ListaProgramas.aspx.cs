using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class ListaProgramas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClProgramaL objProgramaL = new ClProgramaL();
                List<ClProgramaE> listaPrograma = objProgramaL.mtdListarPrograma();
                string Json = JsonConvert.SerializeObject(listaPrograma, Newtonsoft.Json.Formatting.Indented);
                ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);
            }
        }

        [WebMethod]
        public static List<ClProgramaE> mtdCargarDatos(int idPrograma)
        {
            ClProgramaL objPrograma = new ClProgramaL();
            List<ClProgramaE> Programas = objPrograma.mtdListarPorId(idPrograma);
            if (Programas.Count > 0)
            {
                return Programas;
            }
            return null;
        }

        [WebMethod]
        public static string mtdActualizarPrograma(object data)
        {
            ClProgramaL objProgramaL = new ClProgramaL();
            ClProgramaE objProgramaE = new ClProgramaE();

            var datos = data as IDictionary<string, object>;
            objProgramaE.Nombre_Programa = datos["Nombre_Programa"].ToString();
            objProgramaE.Ficha = datos["Ficha"].ToString();
            objProgramaE.Descripcion = datos["Descripcion"].ToString();
            objProgramaE.idPrograma = int.Parse(datos["idPrograma"].ToString());

            int resultado = objProgramaL.mtdActualizacion(objProgramaE);

            return "success";
        }

        [WebMethod]
        public static List<ClProgramaE> mtdListar()
        {
            ClProgramaL objProgramaL = new ClProgramaL();
            List<ClProgramaE> listaPrograma = objProgramaL.mtdListarPrograma();

            return listaPrograma;
        }

        [WebMethod]
        public static string mtdEliminar(object formData)
        {
            ClProgramaL objprograma = new ClProgramaL();
            ClProgramaE objEliminarPrograma = new ClProgramaE();

            var data = formData as IDictionary<string, object>;
            objEliminarPrograma.idPrograma = int.Parse(data["idPrograma"].ToString());

            int resultado = objprograma.mtdEliminar(objEliminarPrograma);
            return string.Empty;
        }

    }
}