using AppControldeIngresosCIMM.Datos;
using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Logica
{
    public class ClVehiculoUs
    {

        public List<ClVehiculoEntidad> mtdVehicu()
        {
            ClVehiculoOr objPersonalD = new ClVehiculoOr();
            List<ClVehiculoEntidad> listarPersonal = objPersonalD.mtdVeheiculoDa();
            return listarPersonal;
        }



    }
}