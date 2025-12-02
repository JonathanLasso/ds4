using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_3_de_DSVI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = @"Server=localhost;
                                  Database=JonathanLasso;
                                  Trusted_Connection=True;
                                  TrustServerCertificate=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txbNombreCaso_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txbDescripcionCaso_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txbTipoCaso_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btAgregarCaso_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO JL_CASOS (Nombre, Descripcion, Tipo_caso)"
                    + "VALUES ('" + txbNombreCaso.Text + "' , '" + txbDescripcionCaso.Text + "' , '" + txbTipoCaso.Text + "')";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Registro ingresado correctamente!');", true);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Error: " + ex.Message.Replace("'", "") + "');", true);
            }
            finally
            {
                con.Close();
            }

            MyGridView.DataBind();
        }
    }
}