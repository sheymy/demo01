using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb01
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///lblUsuario.Text =Session["NyA"].ToString();
            ///

            //HttpCookie ck = HttpContext.Current.Request.Cookies["UserName"];

            //if (ck != null)
            //{
            //    lblUsuario.Text=ck["NyA"];
            //    lblFechaHora.Text = ck["Date"];
            //}
            //
            string NyA = Request.QueryString["NyA"];
            if (!string.IsNullOrEmpty(NyA))
            { lblUsuario.Text = NyA; }

            //lblUsuario.Text = Request.Form["DataOculta"];

            if (!Page.IsPostBack)
            {
               lblFechaHora.Text = DateTime.Now.ToString();
            }
        }
    }
}