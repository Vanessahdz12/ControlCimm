using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClRegistraArticuloD
    {
        public string mtdRefgistrarArticulo(string NombreA, string Descripcion, string Cantidad,
          string TipoAr, int idUsuario)
        {
            ClProcesarSQL selectdesconet = new ClProcesarSQL();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre_Articulo", NombreA),
                new SqlParameter("@Descripcion", Descripcion),
                new SqlParameter("@Cantidad", Cantidad),
                new SqlParameter("@Tipo_Articulo", TipoAr),
                new SqlParameter("@idUsuario", idUsuario)
            };

            DataTable dtIngreso = selectdesconet.CallExecProcedure("RegistrarArticulo", parameters);


            return "";
        }


        public List<ClArticuloEnt> mtdUsuario()
        {
            ClProcesarSQL selectdesconet = new ClProcesarSQL();

            DataTable dtMunicipio = selectdesconet.CallExecProcedure("ArUsuario", null);
            List<ClArticuloEnt> Municipios = new List<ClArticuloEnt>();

            for (int i = 0; i < dtMunicipio.Rows.Count; i++)
            {
                ClArticuloEnt objMunic = new ClArticuloEnt();
                objMunic.ìdUsuario = int.Parse(dtMunicipio.Rows[i]["idUsuario"].ToString());
                objMunic.NombreUsua = dtMunicipio.Rows[i]["Nombre"].ToString();

                Municipios.Add(objMunic);
            }
            return Municipios;
        }


    }
}