using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClGuardaD
    {
        public List<ClGuardaE> mtdListarIngresoSalida(int idGuarda)
        {
            string consulta = "Select * from Articulo inner join Ingreso_Salida [insa] on Articulo.idArticulo = insa.idArticulo where idGuarda = " + idGuarda + "";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblLista = objSql.mtdSelectDesc(consulta);

            List<ClGuardaE> ListaGuarda = new List<ClGuardaE>();
            for (int i = 0; i < tblLista.Rows.Count; i++)
            {
                ClGuardaE objGuarda = new ClGuardaE();
                objGuarda.idGuarda = int.Parse(tblLista.Rows[i]["idGuarda"].ToString());
                objGuarda.Nombre_Articulo = tblLista.Rows[i]["Nombre_Articulo"].ToString();
                objGuarda.Descripcion = tblLista.Rows[i]["Descripcion"].ToString();
                objGuarda.Tipo = tblLista.Rows[i]["Tipo_Articulo"].ToString();
                objGuarda.Fecha_ingreso = tblLista.Rows[i]["Fecha_Ingreso"].ToString();
                objGuarda.Fecha_Salida = tblLista.Rows[i]["Fecha_Salida"].ToString();
                ListaGuarda.Add(objGuarda);
            }
            return ListaGuarda;
        }
    }
}