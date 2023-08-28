using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Entidades
{
    public class ClGuardaE
    {
        public int idGuarda { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Fecha_ingreso { get; set; }
        public string Fecha_Salida { get; set; }
    }
}