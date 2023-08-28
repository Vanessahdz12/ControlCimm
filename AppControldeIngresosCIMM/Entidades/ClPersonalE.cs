using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Entidades
{
    public class ClPersonalE
    {
        public int idUsuario { get; set; }
        public int idPrograma { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Programa { get; set; }
        public string Ficha { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Fecha_Ingreso { get; set; }
        public string Fecha_Salida { get; set; }
        public string Tipo_Porteria { get; set; }
        public string TipoVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string NombreCompleto { get; set; }
    }
}