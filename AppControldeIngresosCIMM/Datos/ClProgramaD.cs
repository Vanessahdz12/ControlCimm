using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClProgramaD
    {
        public string mtdRegistrarPrograma(string nombre, string ficha, string Descripcion)
        {
            ClProcesarSQL selectDesconet = new ClProcesarSQL();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Nombre_Programa",nombre),
                new SqlParameter("@Ficha", ficha),
                new SqlParameter("@Descripcion", Descripcion)
            };
            DataTable dtIngreso = selectDesconet.CallExecProcedure("Registrar_Programa", param);
            return "";
        }

        public List<ClProgramaE> mtdListarProgramas()
        {
            string consulta = "SELECT * FROM Programa";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblProgramas = objSql.mtdSelectDesc(consulta);
            List<ClProgramaE> ListaProgramas = new List<ClProgramaE>();
            for (int i = 0; i < tblProgramas.Rows.Count; i++)
            {
                ClProgramaE objProgramas = new ClProgramaE();
                objProgramas.idPrograma = int.Parse(tblProgramas.Rows[i]["idPrograma"].ToString());
                objProgramas.Nombre_Programa = tblProgramas.Rows[i]["Nombre_Programa"].ToString();
                objProgramas.Descripcion = tblProgramas.Rows[i]["Descripcion"].ToString();
                objProgramas.Ficha = tblProgramas.Rows[i]["Ficha"].ToString();
                ListaProgramas.Add(objProgramas);
            }
            return ListaProgramas;
        }
        public List<ClProgramaE> mtdListarProgramaPorID (int idPrograma)
        {
            string consulta = "Select * from Programa Where idPrograma = " + idPrograma + "";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblProgramas = objSql.mtdSelectDesc(consulta);
            List<ClProgramaE> ListaProgramas = new List<ClProgramaE>();
            for (int i = 0; i < tblProgramas.Rows.Count; i++)
            {
                ClProgramaE objProgramas = new ClProgramaE();
                objProgramas.idPrograma = int.Parse(tblProgramas.Rows[i]["idPrograma"].ToString());
                objProgramas.Nombre_Programa = tblProgramas.Rows[i]["Nombre_Programa"].ToString();
                objProgramas.Descripcion = tblProgramas.Rows[i]["Descripcion"].ToString();
                objProgramas.Ficha = tblProgramas.Rows[i]["Ficha"].ToString();
                ListaProgramas.Add(objProgramas);
            }
            return ListaProgramas;
        }

        public int mtdActualizarPrograma(ClProgramaE ObjPrograma)
        {
            string ProcesoAlmacenado = "ActualizarPrograma";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Actualizar = objSQL.mtdProcesoAlmacenado(ProcesoAlmacenado);

            Actualizar.Parameters.AddWithValue("@Nombre_Programa", ObjPrograma.Nombre_Programa);
            Actualizar.Parameters.AddWithValue("@Ficha", ObjPrograma.Ficha);
            Actualizar.Parameters.AddWithValue("@Descripcion", ObjPrograma.Descripcion);
            Actualizar.Parameters.AddWithValue("@idPrograma", ObjPrograma.idPrograma);
            int DatosActualizar = Actualizar.ExecuteNonQuery();
            return DatosActualizar;
        }

        public int mtdEliminar(ClProgramaE ObjPrograma)
        {
            string consulta = "EliminarPrograma";
            ClProcesarSQL objSql = new ClProcesarSQL();
            SqlCommand Eliminar = objSql.mtdProcesoAlmacenado(consulta);

            Eliminar.Parameters.AddWithValue("@idPrograma", ObjPrograma.idPrograma);

            int DatosActualizar = Eliminar.ExecuteNonQuery();
            return DatosActualizar;
        }
    }
}