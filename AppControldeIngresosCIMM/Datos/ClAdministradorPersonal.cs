using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClAdministradorPersonal
    {
        public List<ClAdmPersonalEn> mtdListTable()
        {

            string Consulta = "SELECT * FROM Usuario";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClAdmPersonalEn> ListarPersonal = new List<ClAdmPersonalEn>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClAdmPersonalEn objPersonalE = new ClAdmPersonalEn();
                objPersonalE.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Correo = tblListarPersonal.Rows[i]["Correo"].ToString();
                objPersonalE.Clave = tblListarPersonal.Rows[i]["Clave"].ToString();
                objPersonalE.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();

                ListarPersonal.Add(objPersonalE);


            }
            return ListarPersonal;
        }


        public List<ClAdmPersonalEn> mtdObtenerPersonalPorId(int Documento)
        {

            string Consulta = "SELECT * FROM Usuario WHERE Documento = " + Documento;

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClAdmPersonalEn> ListarPersonal = new List<ClAdmPersonalEn>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClAdmPersonalEn objPersonalEn = new ClAdmPersonalEn();
                objPersonalEn.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalEn.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalEn.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalEn.Correo = tblListarPersonal.Rows[i]["Correo"].ToString();
                objPersonalEn.Clave = tblListarPersonal.Rows[i]["Clave"].ToString();
                objPersonalEn.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();

                ListarPersonal.Add(objPersonalEn);
            }
            return ListarPersonal;

        }

        public int mtdActualizar(ClAdmPersonalEn objDatos)
        {
            string ProcesosAlmacenado = "ActualizarPersonal";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Actualizar = objSQL.mtdIUDConect(ProcesosAlmacenado);

            // Asegúrate de utilizar las claves correctas para los datos enviados
            Actualizar.Parameters.AddWithValue("@idUsuario", objDatos.idUsuario);
            Actualizar.Parameters.AddWithValue("@Documento", objDatos.Documento);
            Actualizar.Parameters.AddWithValue("@Nombre", objDatos.Nombre);
            Actualizar.Parameters.AddWithValue("@Apellido", objDatos.Apellido);
            Actualizar.Parameters.AddWithValue("@Correo", objDatos.Correo);
            Actualizar.Parameters.AddWithValue("@Clave", objDatos.Clave);
            Actualizar.Parameters.AddWithValue("@Telefono", objDatos.Telefono);

            int DatosActualizar = Actualizar.ExecuteNonQuery();
            return DatosActualizar;
        }


        public int mtdEliminar(ClAdmPersonalEn objDatos)
        {
            string ProcesosAlmacenado = "EliminarRegistro";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Eliminar = objSQL.mtdIUDConect(ProcesosAlmacenado);

            Eliminar.Parameters.AddWithValue("@idUsuario", objDatos.idUsuario);

            int DatosActualizar = Eliminar.ExecuteNonQuery();
            return DatosActualizar;

        }

    }

}