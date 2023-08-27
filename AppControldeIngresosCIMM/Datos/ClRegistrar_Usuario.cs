using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClRegistrar_Usuario
    {
        public string mtdRegisterUsers(string Documento, string Nombre, string Apellido,
          string Correo, string Clave, string Telefono, int idRol)
        {
            ClProcesarSQL selectdesconet = new ClProcesarSQL();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Documento", Documento),
                new SqlParameter("@Nombre", Nombre),
                new SqlParameter("@Apellido", Apellido),
                new SqlParameter("@Correo", Correo),
                new SqlParameter("@Clave", Clave),
                new SqlParameter("@Telefono", Telefono),
                new SqlParameter("@idRol", idRol)
            };

            DataTable dtIngreso = selectdesconet.CallExecProcedure("Registrar_Usuario", parameters);


            return "";
        }
    }
}
