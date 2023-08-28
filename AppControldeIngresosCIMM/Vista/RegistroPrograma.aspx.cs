using AppControldeIngresosCIMM.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppControldeIngresosCIMM.Vista
{
    public partial class RegistroPrograma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_ServerClick(object sender, EventArgs e)
        {
            string nombre = TxtPrograma.Text;
            string ficha = txtFicha.Text;
            string descripcion = txtDescripcion.Value;

            ClProgramaL objprograma = new ClProgramaL();
            string insert = objprograma.mtdRegistrarPrograma(nombre, ficha, descripcion);
            if (insert != "")
            {
                string script = @"<script> swal({ title: '¡Envio Exitoso!',
                              text: 'Registro exitoso', type: 'success',
                            confirmButtonText: 'Aceptar'
                });
                    </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", script, false);
            }
        }
    }
}