using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Entidades
{
    public class ClUsuarioEnt
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Correo { get; set; }
        public string Clave { get; set; }

        public string Telefono { get; set; }

        public int idRol { get; set; }

    }
}