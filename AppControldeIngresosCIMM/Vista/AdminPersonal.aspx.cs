using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class AdminPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClAdminPersonalLo objPersonalL = new ClAdminPersonalLo();
                List<ClAdmPersonalEn> listaPersonal = objPersonalL.mtdListar();
                string Json = JsonConvert.SerializeObject(listaPersonal, Newtonsoft.Json.Formatting.Indented);
                ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);
            }
        }



        [WebMethod]
        public static List<ClAdmPersonalEn> mtdCargarDatos(int Documento)
        {
            ClAdminPersonalLo objPersonal = new ClAdminPersonalLo();
            List<ClAdmPersonalEn> Personal = objPersonal.mtdIdPersonal(Documento);
            return Personal;
        }




        [WebMethod]
        public static string mtdActualizarPersonal(object data)
        {
            ClAdminPersonalLo objPersonalL = new ClAdminPersonalLo();
            ClAdmPersonalEn objActualizarPersonal = new ClAdmPersonalEn();

            var datos = data as IDictionary<string, object>;

            // Asegúrate de que las claves coincidan con las que se envían desde el cliente
            objActualizarPersonal.idUsuario = int.Parse(datos["idUsuario"].ToString());
            objActualizarPersonal.Documento = datos["Documento"].ToString();
            objActualizarPersonal.Nombre = datos["Nombre"].ToString();
            objActualizarPersonal.Apellido = datos["Apellido"].ToString();
            objActualizarPersonal.Correo = datos["Correo"].ToString();
            objActualizarPersonal.Clave = datos["Clave"].ToString();
            objActualizarPersonal.Telefono = datos["Telefono"].ToString();

            int resultado = objPersonalL.mtdActualizacion(objActualizarPersonal);

            return "success"; // Devuelve una respuesta al cliente
        }

        [WebMethod]
        public static List<ClAdmPersonalEn> mtdListar()
        {
            ClAdminPersonalLo objPersonalL = new ClAdminPersonalLo();
            List<ClAdmPersonalEn> listaPersonal = objPersonalL.mtdListar();
            return listaPersonal;
        }


        [WebMethod]
        public static string mtdEliminar(object formData)
        {
            ClAdminPersonalLo objPersonal = new ClAdminPersonalLo();
            ClAdmPersonalEn objEliminarPersonal = new ClAdmPersonalEn();

            var data = formData as IDictionary<string, object>;
            objEliminarPersonal.idUsuario = Convert.ToInt32(data["idUsuario"]);

            int resultado = objPersonal.mtdEliminar(objEliminarPersonal);

            // Puedes retornar una respuesta en formato JSON si lo deseas
            return "{ \"resultado\": \"" + resultado + "\" }";
        }

    }
}