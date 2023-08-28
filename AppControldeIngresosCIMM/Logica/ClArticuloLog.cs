using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClArticuloLog
    {
        ClRegistraArticuloD regis_Articulo = new ClRegistraArticuloD();

        public string mtdRegistrarUsuario(string Nombre_Arti, string Descripcion, string Cantidad,
            string TipoArtu, int idUsuario)
        {
            return regis_Articulo.mtdRefgistrarArticulo(Nombre_Arti, Descripcion, Cantidad, TipoArtu, idUsuario);
        }


        public List<ClArticuloEnt> mtdGetUsua()
        {
            return regis_Articulo.mtdUsuario();
        }

    }

}