using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClRolL
    {
        public List<ClRolE> mtdListarRol()
        {
            ClRolD objRol = new ClRolD();
            List<ClRolE> listaRol = objRol.mtdListarRol();
            return listaRol;
        }
    }
}