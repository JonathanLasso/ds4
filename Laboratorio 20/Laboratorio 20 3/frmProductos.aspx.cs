using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace Laboratorio_20_3
{
    public partial class InventarioProductos : System.Web.UI.Page
    {
        string connectionString = @"Server=localhost;
                                  Database=Productos;
                                  Trusted_Connection=True;
                                  TrustServerCertificate=True;";
       
        public bool Nuevo
        {
            get
            {
                return ViewState["nuevoProducto"] != null ? (bool)ViewState["nuevoProducto"] : false;
            }
            set
            {
                ViewState["nuevoProducto"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        protected void tsbNuevo_Click(object sender, ImageClickEventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            Nuevo = true;
        }

        protected void tsbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            if (Nuevo)
            {
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK)"
                    + "VALUES ('" + txtNombre.Text + "' , '" + txtPrecio.Text + "' , '" + txtStock.Text + "')";

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
            }

            else
            {
                string sql = "UPDATE LAPTOPS SET NOMBRE='" + txtNombre.Text +
                    "', PRECIO='" + txtPrecio.Text +
                    "' , " + "STOCK='" + txtStock.Text + "' WHERE id=" + txtId.Text + "";

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
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            Nuevo = false;
        }

        protected void tsbCancelar_Click(object sender, ImageClickEventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void tsbEliminar_Click(object sender, ImageClickEventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE id='" + this.txtId.Text + "';";

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

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        protected void tsbBuscar_Click(object sender, ImageClickEventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID=" + tstId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tstId.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtPrecio.Text = reader[2].ToString();
                    txtStock.Text = reader[3].ToString();
                    Nuevo = false;
                }

                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Ningun registro encontrado con el Id ingresado!');", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Error: " + ex.Message.Replace("'", "") + "');", true);
            }
            finally
            {
                con.Close();
            }

            tstId.Text = "";
        }
    }
}