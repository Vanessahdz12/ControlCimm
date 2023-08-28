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
    public partial class ListaPersonalPrograma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> ListaPersonal = objPersonal.mtdListar();
            string Json = JsonConvert.SerializeObject(ListaPersonal);
            ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);
        }

        [WebMethod]
        public static List<ClPersonalE> mtdCargarDatos(int IdPersonal)
        {
            ClPersonalL objPersonal = new ClPersonalL();
            List<ClPersonalE> Personal = objPersonal.mtdIdPersonal(IdPersonal);
            if (Personal.Count > 0)
            {
                return Personal;
            }
            return null;
        }

        [WebMethod]
        public static string mtdActualizarPersonal(object data)
        {
            ClPersonalL objPersonalL = new ClPersonalL();
            ClPersonalE objActualizarPersonal = new ClPersonalE();

            var datos = data as IDictionary<string, object>;

            objActualizarPersonal.Documento = datos["Documento"].ToString();
            objActualizarPersonal.Nombre = datos["Nombre"].ToString();
            objActualizarPersonal.Apellido = datos["Apellido"].ToString();
            objActualizarPersonal.Telefono = datos["Telefono"].ToString();
            objActualizarPersonal.Programa = datos["Nombre_Programa"].ToString();
            objActualizarPersonal.Ficha = datos["Ficha"].ToString();
            objActualizarPersonal.idUsuario = int.Parse(datos["idUsuario"].ToString());
            objActualizarPersonal.idPrograma = int.Parse(datos["idPrograma"].ToString());

            int resultado = objPersonalL.mtdActualizacion(objActualizarPersonal);

            return "success"; // Devuelve una respuesta al cliente
        }

        [WebMethod]
        public static List<ClPersonalE> mtdListar()
        {
            ClPersonalL objPersonalL = new ClPersonalL();
            List<ClPersonalE> listaPersonal = objPersonalL.mtdListarPersonal();

            return listaPersonal;
        }

        [WebMethod]
        public static string mtdEliminar(object formData)
        {
            ClPersonalL objPersonal = new ClPersonalL();
            ClPersonalE objEliminarPersonal = new ClPersonalE();

            var data = formData as IDictionary<string, object>;
            int idPersonal = int.Parse(data["IdPersonal"].ToString());

            int resultado = objPersonal.mtdEliminar(idPersonal);
            return string.Empty;
        }
    }
}