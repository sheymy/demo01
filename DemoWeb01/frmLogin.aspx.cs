using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DemoWeb01
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Pachacamac;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            DataSet ds= new DataSet();
            cmd.CommandText = "Validar_Usuario";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@clave", txtClave.Text);
            conn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Session.Add("NyA", dr["NombreyApellidos"].ToString());
                //Session.Add("dataset", ds);
                ///
                //HttpCookie Ck = new HttpCookie("UserName");
                //Ck["NyA"]= dr["NombreyApellidos"].ToString();
                ///Ck["Date"] = DateTime.Now.ToString();
                ///Ck.Expires = DateTime.Now.AddDays(1);
                //HttpContext.Current.Response.Cookies.Add(Ck);  
                //
                //DataOculta.Value = dr["NombreyApellidos"].ToString();
                Response.Redirect("MenuPrincipal.aspx");
            }
            else
            {
                Response.Write("Existe un error en el usuario o clave");
            }
            conn.Close();


        }

    }
}