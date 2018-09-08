using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Obligatorio;

namespace Interfaz
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool menu1 = false;
            bool menu2 = false;

           // Session["EstadoMenu1"] = menu1;
            //Session["EstadoMenu2"] = menu2;

            string nombre = Login1.UserName;
            string password = Login1.Password;

            
            Session["NombreUsuario"] = nombre;
            Session["TipoUsuario"] = 1;
            e.Authenticated = true;
            Response.Redirect("Principal.aspx");
        }


    }
}