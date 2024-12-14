using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using quiz.CapaModelo;
using quiz.CapaLogica;

namespace quiz.CapaVistas
{
    public partial class Class : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              

                llenargrid();
            }

        }

        private void llenargrid()
        {
            List<Cls_Class> clases = Business_Class.ObtenerClases();

            GridView1.DataSource = clases;
            GridView1.DataBind();
        }

       
        protected void bconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(tcodigo.Text);
                List<Cls_Class> clases = Business_Class.ObtenerClasesFiltro(codigo);
                GridView1.DataSource = clases;
                GridView1.DataBind();
            }
            catch (Exception)
            {

                DBConn.JavaScriptHelper.MostrarAlerta(this, "Codigo no existe");
            }
           
           
        }

        protected void baagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Business_Class.AgregarClass(tnombre.Text) > 0)
                {
                    DBConn.JavaScriptHelper.MostrarAlerta(this, "Clase ingresada");
                    llenargrid();
                }
                else
                {
                    DBConn.JavaScriptHelper.MostrarAlerta(this, "error");
                }
            }
            catch (Exception)
            {

                DBConn.JavaScriptHelper.MostrarAlerta(this, "error");
            }
            
        }
    }
}