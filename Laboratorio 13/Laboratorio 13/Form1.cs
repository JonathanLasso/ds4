using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionString = 
            @"Server=localhost;
            Database=Northwind;
            Trusted_Connection=True;
            TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectarDesconectarSql_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);

                conexion.Open();

                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

                string query = "SELECT ProductName FROM Products";

                SqlCommand cmd = new SqlCommand(query, conexion);
                
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    string producto = $"{rdr["ProductName"]}";
                    listBox1.Items.Add(producto);
                }
                
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");

            }catch (Exception z)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
