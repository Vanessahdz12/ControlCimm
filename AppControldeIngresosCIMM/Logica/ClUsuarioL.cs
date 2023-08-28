using AppControldeIngresosCIMM.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClUsuarioL
    {
        public int mtdVerificarCorreo(string correo)
        {
            ClUsuarioD objUsuario = new ClUsuarioD();
            int usuario = objUsuario.mtdVerificarCorreo(correo);
            return usuario;
        }

        public int mtdCambiarClave(string correo, string clave)
        {
            ClUsuarioD objUsuario = new ClUsuarioD();
            int usuario = objUsuario.mtdCambiarContraseña(correo, clave);
            return usuario;
        }
    }
}