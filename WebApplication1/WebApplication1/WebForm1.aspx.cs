using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Utente"]["Username"] != "")
            {
                Label1.Text ="Username: " + Request.Cookies["Utente"]["Username"];
            }
            else
            {
                Response.Redirect("Default");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie coockie = new HttpCookie("Utente");

            coockie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(coockie);
            Response.Redirect("Default");
        }
    }
}