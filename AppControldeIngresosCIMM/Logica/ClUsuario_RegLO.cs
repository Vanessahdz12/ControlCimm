using AppControldeIngresosCIMM.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClUsuario_RegLO
    {
        ClRegistrar_Usuario regis_Usu = new ClRegistrar_Usuario();

        public string mtdRegistrarUsuario(string Documento, string Nombre, string Apellido,
            string Correo, string Clave, string Telefono, int idRol)
        {
            return regis_Usu.mtdRegisterUsers(Documento, Nombre, Apellido, Correo, Clave, Telefono, idRol);
        }
    }
}

