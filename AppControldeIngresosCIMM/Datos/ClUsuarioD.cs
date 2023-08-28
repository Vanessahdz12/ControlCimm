using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClUsuarioD
    {
        public int mtdVerificarCorreo(string correo)
        {
            string consulta = "SELECT COUNT(*) FROM Usuario WHERE Correo= '" + correo + "'";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            int consul = objSQL.mtdVerificarExistenciaCorreo(consulta);
            return consul;
        }

        public int mtdCambiarContraseña(string email, string NuevaClave)
        {
            string Update = "UPDATE Usuario SET Clave = '" + NuevaClave + "' where Correo='" + email + "'";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            int Actualizar = objSQL.mtdIUDConec(Update);
            return Actualizar;
        }
    }
}