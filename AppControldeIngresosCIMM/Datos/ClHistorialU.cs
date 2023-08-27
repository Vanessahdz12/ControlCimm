using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClHistorialU
    {
        public List<ClHistorialEn> mtdHistorialAd()
        {

            string Consulta = "SELECT sd.Fecha_Ingreso, sd.Estado, sd.Tipo, U.Nombre, U.Correo, A.Nombre_Articulo, A.Cantidad " +
                 "FROM Ingreso_Salida Sd JOIN Usuario U ON sd.idUsuario = U.idUsuario JOIN Articulo A ON sd.idArticulo = A.idArticulo";


            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblHistoriall = objSQL.mtdSelectDesc(Consulta);
            List<ClHistorialEn> Historial = new List<ClHistorialEn>();
            for (int i = 0; i < tblHistoriall.Rows.Count; i++)
            {
                ClHistorialEn objPersonalE = new ClHistorialEn();
                objPersonalE.Estado = tblHistoriall.Rows[i]["Estado"].ToString();
                objPersonalE.Tipo = tblHistoriall.Rows[i]["Tipo"].ToString();
                objPersonalE.Nombre = tblHistoriall.Rows[i]["Nombre"].ToString();
                objPersonalE.Correo = tblHistoriall.Rows[i]["Correo"].ToString();
                objPersonalE.Nombre_Articulo = tblHistoriall.Rows[i]["Nombre_Articulo"].ToString();
                objPersonalE.Cantidad = tblHistoriall.Rows[i]["Cantidad"].ToString();
                objPersonalE.Fecha_Ingreso = tblHistoriall.Rows[i]["Fecha_Ingreso"].ToString();




                Historial.Add(objPersonalE);


            }
            return Historial;
        }




    }
}