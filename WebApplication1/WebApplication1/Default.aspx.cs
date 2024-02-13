using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie coockie = new HttpCookie("Utente");
            coockie.Values["Username"] = Username.Text;
            coockie.Values["Password"] = Password.Text;
            coockie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(coockie);

            Response.Redirect("WebForm1");
        }
    }
}