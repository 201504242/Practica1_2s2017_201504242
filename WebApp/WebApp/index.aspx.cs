using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//dashboard
        {
            Response.Redirect("dashboard.aspx");
        }

        protected void adminMensajes_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminMensajes.aspx");
        }

        protected void Reportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("reportes.aspx");
        }
    }
}