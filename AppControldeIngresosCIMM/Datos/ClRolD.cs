using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClRolD
    {
        public List<ClRolE> mtdListarRol()
        {
            string consulta = "Select * from Rol";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblRol = objSql.mtdSelectDesc(consulta);

            List<ClRolE> listaRol = new List<ClRolE>();
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                ClRolE objRol = new ClRolE();
                objRol.idRol = int.Parse(tblRol.Rows[i]["idRol"].ToString());
                objRol.Rol = tblRol.Rows[i]["Rol"].ToString();
                listaRol.Add(objRol);
            }
            return listaRol;
        }
    }
}