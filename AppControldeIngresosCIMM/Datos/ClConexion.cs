using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppControldeIngresosCIMM.Datos
{
    public class ClConexion
    {
        SqlConnection conexion = null;
        public SqlConnection mtdConexion()
        {
            conexion = new SqlConnection("Data Source=LAPTOP-NGR8K750;Initial Catalog=Control;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}