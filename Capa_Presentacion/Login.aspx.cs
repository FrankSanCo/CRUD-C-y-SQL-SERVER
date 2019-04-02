using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            E_Usuario objUsuario = N_Usuario.Instancia.AccesoSistema(txtUser.Text, txtPassword.Text);

            if (objUsuario != null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMensaje.Text = ("Credenciales incorrectas");
            }

        }
    }
}