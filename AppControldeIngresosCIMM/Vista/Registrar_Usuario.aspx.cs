using AppControldeIngresosCIMM.Entidades;
using AppControldeIngresosCIMM.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class Registrar_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegiostrar_Click(object sender, EventArgs e)
        {

            ClUsuarioEnt objsUsers = new ClUsuarioEnt();
            objsUsers.Documento = txtDocumento.Text;
            objsUsers.Nombre = txtNombre.Text;
            objsUsers.Apellido = txtApellido.Text;
            objsUsers.Correo = txtCorreo.Text;
            objsUsers.Clave = txtClave.Text;
            objsUsers.Telefono = txtTelefono.Text;

            int selectedRoleId = 0;

            if (RadioButton1.Checked)
            {

                selectedRoleId = 1;
            }
            else if (RadioButton2.Checked)
            {

                selectedRoleId = 2;
            }

            objsUsers.idRol = selectedRoleId;

            ClUsuario_RegLO objUslogic = new ClUsuario_RegLO();
            string Result = objUslogic.mtdRegistrarUsuario(objsUsers.Documento, objsUsers.Nombre, objsUsers.Apellido, objsUsers.Correo,
                objsUsers.Clave, objsUsers.Telefono, objsUsers.idRol);
            string script;




            if (string.IsNullOrEmpty(Result))
            {

                string mensaje = "Datos Registrados";
                script = "<script type=\"text/javascript\">alert('" + mensaje + "');</script>";

                // Limpiar los campos después de un registro exitoso
                txtDocumento.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtClave.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                script = "<script type=\"text/javascript\">alert('" + Result + "');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script);
            }

            ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", script);
        }
    }
}
