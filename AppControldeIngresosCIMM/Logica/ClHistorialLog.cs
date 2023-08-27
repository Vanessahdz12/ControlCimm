using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClHistorialLog
    {

        public List<ClHistorialEn> mtdHistorialLog()
        {
            ClHistorialU objHistorialD = new ClHistorialU();
            List<ClHistorialEn> His = objHistorialD.mtdHistorialAd();
            return His;
        }

    }
}