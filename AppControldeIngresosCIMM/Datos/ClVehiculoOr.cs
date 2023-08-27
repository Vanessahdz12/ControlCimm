using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClVehiculoOr
    {
        public List<ClVehiculoEntidad> mtdVeheiculoDa()
        {

            string Consulta = "SELECT Vh.TipoVehiculo, Vh.Placa, Us.Nombre, Us.Telefono " +
                    "FROM Vehiculo Vh " +
                    "JOIN Usuario Us ON Vh.idUsuario = Us.idUsuario";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblHistorialU = objSQL.mtdSelectDesc(Consulta);
            List<ClVehiculoEntidad> ListHist = new List<ClVehiculoEntidad>();
            for (int i = 0; i < tblHistorialU.Rows.Count; i++)
            {
                ClVehiculoEntidad objHistoE = new ClVehiculoEntidad();
                objHistoE.NombreUsua = tblHistorialU.Rows[i]["Nombre"].ToString();
                objHistoE.placa = tblHistorialU.Rows[i]["Placa"].ToString();
                objHistoE.TipoVehiculo = tblHistorialU.Rows[i]["TipoVehiculo"].ToString();
                objHistoE.Telefono = tblHistorialU.Rows[i]["Telefono"].ToString();

                ListHist.Add(objHistoE);


            }
            return ListHist;
        }
    }
}