using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DemoWeb01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Pachacamac;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                cargadatagrid();



            }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hola a todos";
            TextBox1.Text = "Datos de servidor";
            Text2.Value = "Hola nuevamente";

        }


        public class clsCategoria
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Descrip { get; set; }
            public string ArchivoImagen { get; set; }
            public DateTime? FechaCreacion { get; set; }
            public DateTime? FechaUltimaModificacion { get; set; }
            public bool? Activa { get; set; }

            // Constructor vacío
            public clsCategoria()
            {
            }

            // Constructor con parámetros obligatorios
            public clsCategoria(string nombre)
            {
                Nombre = nombre;
            }

            // Constructor con todos los parámetros
            public clsCategoria(string nombre, string descrip, string archivoImagen, DateTime? fechaCreacion, DateTime? fechaUltimaModificacion, bool? activa)
            {
                Nombre = nombre;
                Descrip = descrip;
                ArchivoImagen = archivoImagen;
                FechaCreacion = fechaCreacion;
                FechaUltimaModificacion = fechaUltimaModificacion;
                Activa = activa;
            }

            // Método para imprimir información de la categoría
            public override string ToString()
            {
                return $"Categoria(Id={Id}, Nombre={Nombre}, Descrip={Descrip}, ArchivoImagen={ArchivoImagen}, FechaCreacion={FechaCreacion}, FechaUltimaModificacion={FechaUltimaModificacion}, Activa={Activa})";
            }
        }

        protected void GridCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete FROM Categorias where id = " + GridCategorias.Rows[e.RowIndex].Cells[0].Text;
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cargadatagrid();
        }

        void cargadatagrid()
        {
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader dr;
            List<clsCategoria> list = new List<clsCategoria>();

            cmd.CommandText = "SELECT * FROM Categorias";
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                clsCategoria xCategoria = new clsCategoria();
                xCategoria.Id = int.Parse(dr["Id"].ToString());
                xCategoria.Nombre = dr["Nombre"].ToString();
                xCategoria.Descrip = dr["Descrip"].ToString();
                xCategoria.ArchivoImagen = dr["ArchivoImagen"].ToString();
                xCategoria.FechaCreacion = !string.IsNullOrEmpty(dr["FechaCreacion"].ToString()) ? DateTime.Parse(dr["FechaCreacion"].ToString()) : (DateTime?)null;
                xCategoria.FechaUltimaModificacion = !string.IsNullOrEmpty(dr["Fecha_UltimaModificacion"].ToString()) ? DateTime.Parse(dr["Fecha_UltimaModificacion"].ToString()) : (DateTime?)null;
                xCategoria.Activa = Boolean.Parse(dr["Activa"].ToString());
                list.Add(xCategoria);
                dr.Read();
            }
            dr.Close();
            con.Close();
            GridCategorias.DataSource = list;
            GridCategorias.DataBind();
        }

        protected void GridCategorias_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if(e.Exception==null)
            { GridCategorias.EditIndex = -1; cargadatagrid(); }
            else
            { GridCategorias.EditIndex = 0; cargadatagrid();  Response.Write("Error : " + e.Exception.Message); }

        }

        protected void GridCategorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void GridCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridCategorias.EditIndex = -1;
            cargadatagrid();
        }

        protected void GridCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "update Categorias set Nombre='"+ e.NewValues["Nombre"].ToString() + "', Descrip= '" + e.NewValues["Descrip"].ToString() + "' where id = " + e.NewValues["ID"].ToString() ;
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridCategorias.EditIndex = -1;
            cargadatagrid();
        }
    }
}