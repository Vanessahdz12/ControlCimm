using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClProcesarSQL
    {
        //Ejecuta Consulta Select en forma desconectada y retorna DataTable
        public DataTable mtdSelectDesc(string Consulta)
        {

            ClConexion objConexion = new ClConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, objConexion.mtdConexion());
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.mtdConexion().Close();
            return tblDatos;
        }

        public DataTable CallExecProcedure(string procedure, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            ClConexion conexion = new ClConexion();

            using (SqlCommand command = new SqlCommand(procedure, conexion.mtdConexion()))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public SqlCommand mtdProcesoAlmacenado(string ProcesoAlmacenado)
        {
            ClConexion objConexion = new ClConexion();
            SqlCommand comando = new SqlCommand(ProcesoAlmacenado, objConexion.mtdConexion());
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }
      
        public int mtdVerificarExistenciaCorreo(string consul)
        {
            ClConexion obConexion = new ClConexion();
            SqlCommand comando = new SqlCommand(consul, obConexion.mtdConexion());
            int verificar = (int)comando.ExecuteScalar();
            obConexion.mtdConexion().Close();
            return verificar;
        }

        public int mtdIUDConec(string consulta)
        {
            ClConexion objConexion = new ClConexion();
            using (SqlConnection con = objConexion.mtdConexion())
            {
                SqlCommand comando = new SqlCommand(consulta, con);
                int registro = comando.ExecuteNonQuery();
                objConexion.mtdConexion().Close();
                return registro;
            }

        }
    }
}