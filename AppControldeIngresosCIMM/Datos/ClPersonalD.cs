using AppControldeIngresosCIMM.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClPersonalD
    {
        //Lista Aprendices e instructores que pertencen a los programas de formacion
        public List<ClPersonalE> mtdLista()
        {
            string consulta = "Select * from Usuario inner join Rol on Usuario.idRol = Rol.idRol inner join Programa on " +
                "Usuario.idPrograma = Programa.idPrograma";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblPersonal = objSQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();
            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Telefono = tblPersonal.Rows[i]["Telefono"].ToString();
                objPersonalE.Correo = tblPersonal.Rows[i]["Correo"].ToString();
                objPersonalE.Programa = tblPersonal.Rows[i]["Nombre_Programa"].ToString();
                objPersonalE.Ficha = tblPersonal.Rows[i]["Ficha"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscar(string tipoPer = "", string ficha = "")
        {
            string consulta = "";
            if (tipoPer != "" && ficha == "")
            {
                consulta = "Select * from Usuario inner join Rol on Usuario.idRol = Rol.idRol inner join Programa on Usuario.idPrograma = Programa.idPrograma where Usuario.idRol = '" + tipoPer + "'";
            }
            else if (tipoPer == "" && ficha != "")
            {
                consulta = "Select * from Usuario inner join Rol on Usuario.idRol = Rol.idRol inner join Programa on Usuario.idPrograma = Programa.idPrograma" +
                    "where Programa.Ficha= " + ficha + "";
            }
            ClProcesarSQL SQL = new ClProcesarSQL();
            DataTable tblPersonal = SQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();

            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Telefono = tblPersonal.Rows[i]["Telefono"].ToString();
                objPersonalE.Correo = tblPersonal.Rows[i]["Correo"].ToString();
                objPersonalE.Programa = tblPersonal.Rows[i]["Nombre_Programa"].ToString();
                objPersonalE.Ficha = tblPersonal.Rows[i]["Ficha"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;

        }

        //Lista los articulos y las personas que entran por cada una de las porterias
        public List<ClPersonalE> mtdListaArticulosPorterias()
        {
            string consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Art.Nombre_Articulo, insa.Fecha_Ingreso,Fecha_salida, por.Tipo_Porteria, Rol.Rol " +
                "FROM Usuario INNER JOIN Articulo Art ON Usuario.idUsuario = Art.idUsuario INNER JOIN Ingreso_Salida insa ON Usuario.idUsuario = insa.idUsuario " +
                "INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblPersonal = objSQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();
            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Nombre_Articulo = tblPersonal.Rows[i]["Nombre_Articulo"].ToString();
                objPersonalE.Fecha_Ingreso = tblPersonal.Rows[i]["Fecha_Ingreso"].ToString();
                objPersonalE.Fecha_Salida = tblPersonal.Rows[i]["Fecha_Salida"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                objPersonalE.Tipo_Porteria = tblPersonal.Rows[i]["Tipo_Porteria"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscarArticulosPorterias(string tipoPer = "", string porteria = "")
        {
            string consulta = "";
            if (tipoPer != "" && porteria == "")
            {
                consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Art.Nombre_Articulo, insa.Fecha_Ingreso,Fecha_salida, por.Tipo_Porteria, Rol.Rol " +
                "FROM Usuario INNER JOIN Articulo Art ON Usuario.idUsuario = Art.idUsuario INNER JOIN Ingreso_Salida insa ON Usuario.idUsuario = insa.idUsuario " +
                "INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol where Usuario.idRol =" + tipoPer + "";
            }
            else if (tipoPer == "" && porteria != "")
            {
                consulta = consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Art.Nombre_Articulo, insa.Fecha_Ingreso,Fecha_salida, por.Tipo_Porteria, Rol.Rol " +
                "FROM Usuario INNER JOIN Articulo Art ON Usuario.idUsuario = Art.idUsuario INNER JOIN Ingreso_Salida insa ON Usuario.idUsuario = insa.idUsuario " +
                "INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol where Por.idPorteria = " + porteria + "";
            }
            ClProcesarSQL SQL = new ClProcesarSQL();
            DataTable tblPersonal = SQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();

            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Nombre_Articulo = tblPersonal.Rows[i]["Nombre_Articulo"].ToString();
                objPersonalE.Fecha_Ingreso = tblPersonal.Rows[i]["Fecha_Ingreso"].ToString();
                objPersonalE.Fecha_Salida = tblPersonal.Rows[i]["Fecha_Salida"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                objPersonalE.Tipo_Porteria = tblPersonal.Rows[i]["Tipo_Porteria"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;
        }

        //Lista los vehiculos y las personas que ingresan por cada una de las porterias
        public List<ClPersonalE> mtdListaVehiculosPorterias()
        {
            string consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Veh.TipoVehiculo,Marca,Placa, insa.Fecha_Ingreso,Fecha_salida," +
                "por.Tipo_Porteria, Rol.Rol FROM Usuario INNER JOIN Vehiculo Veh ON Usuario.idUsuario = Veh.idUsuario INNER JOIN Ingreso_Salida insa " +
                "ON Usuario.idUsuario = insa.idUsuario INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblPersonal = objSQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();
            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.TipoVehiculo = tblPersonal.Rows[i]["TipoVehiculo"].ToString();
                objPersonalE.Fecha_Ingreso = tblPersonal.Rows[i]["Fecha_Ingreso"].ToString();
                objPersonalE.Marca = tblPersonal.Rows[i]["Marca"].ToString();
                objPersonalE.Placa = tblPersonal.Rows[i]["Placa"].ToString();
                objPersonalE.Fecha_Salida = tblPersonal.Rows[i]["Fecha_Salida"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                objPersonalE.Tipo_Porteria = tblPersonal.Rows[i]["Tipo_Porteria"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;
        }

        public List<ClPersonalE> mtdBuscarVehiculosPorterias(string tipoPer = "", string porteria = "")
        {
            string consulta = "";
            if (tipoPer != "" && porteria == "")
            {
                consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Veh.TipoVehiculo,Marca,Placa, insa.Fecha_Ingreso,Fecha_salida," +
                "por.Tipo_Porteria, Rol.Rol FROM Usuario INNER JOIN Vehiculo Veh ON Usuario.idUsuario = Veh.idUsuario INNER JOIN Ingreso_Salida insa " +
                "ON Usuario.idUsuario = insa.idUsuario INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol where Usuario.idRol = " + tipoPer + "";
            }
            else if (tipoPer == "" && porteria != "")
            {
                consulta = consulta = "SELECT DISTINCT Usuario.Documento, Nombre, Apellido, Veh.TipoVehiculo,Marca,Placa, insa.Fecha_Ingreso,Fecha_salida," +
                "por.Tipo_Porteria, Rol.Rol FROM Usuario INNER JOIN Vehiculo Veh ON Usuario.idUsuario = Veh.idUsuario INNER JOIN Ingreso_Salida insa " +
                "ON Usuario.idUsuario = insa.idUsuario INNER JOIN Porteria por ON insa.idPorteria = por.idPorteria INNER JOIN Rol ON Usuario.idRol = Rol.IdRol where Por.idPorteria = " + porteria + "";
            }
            ClProcesarSQL SQL = new ClProcesarSQL();
            DataTable tblPersonal = SQL.mtdSelectDesc(consulta);

            List<ClPersonalE> listaPersonal = new List<ClPersonalE>();

            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();
                objPersonalE.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.TipoVehiculo = tblPersonal.Rows[i]["TipoVehiculo"].ToString();
                objPersonalE.Fecha_Ingreso = tblPersonal.Rows[i]["Fecha_Ingreso"].ToString();
                objPersonalE.Marca = tblPersonal.Rows[i]["Marca"].ToString();
                objPersonalE.Placa = tblPersonal.Rows[i]["Placa"].ToString();
                objPersonalE.Fecha_Salida = tblPersonal.Rows[i]["Fecha_Salida"].ToString();
                objPersonalE.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                objPersonalE.Tipo_Porteria = tblPersonal.Rows[i]["Tipo_Porteria"].ToString();
                listaPersonal.Add(objPersonalE);
            }
            return listaPersonal;
        }

        //Actualizar personal según programa

        public List<ClPersonalE> mtdListarPersonalPrograma()
        {
            string consulta = "Select * from Usuario inner join Programa on Usuario.idPrograma = Programa.idPrograma";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblListar = objSql.mtdSelectDesc(consulta);
            List<ClPersonalE> ListaPersonal = new List<ClPersonalE>();

            for (int i = 0; i < tblListar.Rows.Count; i++)
            {
                ClPersonalE objPersonal = new ClPersonalE();
                objPersonal.idUsuario = int.Parse(tblListar.Rows[i]["idUsuario"].ToString());
                objPersonal.Documento = tblListar.Rows[i]["Documento"].ToString();
                objPersonal.Nombre = tblListar.Rows[i]["Nombre"].ToString();
                objPersonal.Apellido = tblListar.Rows[i]["Apellido"].ToString();
                objPersonal.Telefono = tblListar.Rows[i]["Telefono"].ToString();
                objPersonal.idPrograma = int.Parse(tblListar.Rows[i]["Telefono"].ToString());
                objPersonal.Programa = tblListar.Rows[i]["Nombre_Programa"].ToString();
                objPersonal.Ficha = tblListar.Rows[i]["Ficha"].ToString();
                ListaPersonal.Add(objPersonal);
            }
            return ListaPersonal;
        }

        public int mtdActualizarPersonaPrograma(ClPersonalE ObjPersona)
        {
            string ProcesosPersona = "ActualizarDatosPersonal";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Actualizar = objSQL.mtdProcesoAlmacenado(ProcesosPersona);

            Actualizar.Parameters.AddWithValue("@Documento", ObjPersona.Documento);
            Actualizar.Parameters.AddWithValue("@Nombre", ObjPersona.Nombre);
            Actualizar.Parameters.AddWithValue("@Apellido", ObjPersona.Apellido);
            Actualizar.Parameters.AddWithValue("@Telefono", ObjPersona.Telefono);
            Actualizar.Parameters.AddWithValue("@Programa", ObjPersona.Programa);
            Actualizar.Parameters.AddWithValue("@Ficha", ObjPersona.Ficha);
            Actualizar.Parameters.AddWithValue("@idUsuario", ObjPersona.idUsuario);
            Actualizar.Parameters.AddWithValue("@idPrograma", ObjPersona.idPrograma);

            int DatosActualizar = Actualizar.ExecuteNonQuery();
            return DatosActualizar;
        }

        public List<ClPersonalE> mtdObtenerPersonalPorId(int idUsuario)
        {

            string Consulta = "Select * from Usuario inner join Programa on Usuario.idPrograma = Programa.idPrograma where idUsuario = " + idUsuario;

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClPersonalE> ListarPersonal = new List<ClPersonalE>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonalE = new ClPersonalE();

                objPersonalE.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();
                objPersonalE.Programa = tblListarPersonal.Rows[i]["Nombre_Programa"].ToString();
                objPersonalE.Ficha = tblListarPersonal.Rows[i]["Ficha"].ToString();

                ListarPersonal.Add(objPersonalE);
            }
            return ListarPersonal;
        }

        public int mtdEliminarPersonal(int IdUsuario)
        {
            string consulta = "Delete from Usuario where idUsuario = " + IdUsuario + "";
            ClProcesarSQL objSql = new ClProcesarSQL();
            int Eliminar = objSql.mtdIUDConec(consulta);
            return Eliminar;
        }

        public List<ClPersonalE> mtdListarIngresoSalidaPersonal()
        {
            string consulta = "select * from Usuario inner join Ingreso_Salida [insa] on Usuario.idUsuario = insa.idUsuario inner join Rol on Rol.idRol = Usuario.idRol";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable tblPersonal = objSql.mtdSelectDesc(consulta);

            List<ClPersonalE> Lista = new List<ClPersonalE>();
            for (int i = 0; i < tblPersonal.Rows.Count; i++)
            {
                ClPersonalE objPersonal = new ClPersonalE();
                objPersonal.idUsuario = int.Parse(tblPersonal.Rows[i]["idUsuario"].ToString());
                objPersonal.Documento = tblPersonal.Rows[i]["Documento"].ToString();
                objPersonal.Nombre = tblPersonal.Rows[i]["Nombre"].ToString();
                objPersonal.Apellido = tblPersonal.Rows[i]["Apellido"].ToString();
                objPersonal.Telefono = tblPersonal.Rows[i]["Telefono"].ToString();
                objPersonal.Fecha_Ingreso = tblPersonal.Rows[i]["Fecha_Ingreso"].ToString();
                objPersonal.Fecha_Salida = tblPersonal.Rows[i]["Fecha_Salida"].ToString();
                objPersonal.Rol = tblPersonal.Rows[i]["Rol"].ToString();
                Lista.Add(objPersonal);
            }
            return Lista;
        }

        public List<ClPersonalE> mtdDetallesVehiculo()
        {
            string consulta = "Select * from Vehiculo inner join Usuario on Vehiculo.idUsuario = Usuario.idUsuario";
            ClProcesarSQL objSql = new ClProcesarSQL();
            DataTable dtVehiculo = objSql.mtdSelectDesc(consulta);

            List<ClPersonalE> LISTA = new List<ClPersonalE>();
            for (int i = 0; i < dtVehiculo.Rows.Count; i++)
            {
                ClPersonalE objPersonal = new ClPersonalE();
                objPersonal.TipoVehiculo = dtVehiculo.Rows[i]["TipoVehiculo"].ToString();
                objPersonal.Marca = dtVehiculo.Rows[i]["Marca"].ToString();
                objPersonal.Modelo = dtVehiculo.Rows[i]["Modelo"].ToString();
                objPersonal.Placa = dtVehiculo.Rows[i]["Placa"].ToString();
                objPersonal.Nombre = dtVehiculo.Rows[i]["Nombre"].ToString();
                objPersonal.Apellido = dtVehiculo.Rows[i]["Apellido"].ToString();
                objPersonal.NombreCompleto = objPersonal.Nombre + " " + objPersonal.Apellido;
                LISTA.Add(objPersonal);
            }
            return LISTA;
        }

    }
}