using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClGuardaL
    {
        public List<ClGuardaE> mtdListarArticuloIngresoSalida(int idGuarda)
        {
            ClGuardaD objGuarda = new ClGuardaD();
            List<ClGuardaE> Lista = objGuarda.mtdListarIngresoSalida(idGuarda);
            return Lista;
        }
    }
}