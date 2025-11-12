using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_2
{
    public partial class matrizNxN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtTamaño_TextChanged(object sender, EventArgs e)
        {
            if (TxtTamaño.Text == "")
                return;
        }

        protected void BtnCrearMatriz_Click(object sender, EventArgs e)
        {
            int tamaño;
            try
            {
                tamaño = int.Parse(TxtTamaño.Text);
                if(tamaño <= 0)
                {
                    TableMatriz.Controls.Add(mensajeError("No se permiten números negativos o igual a cero."));
                }
                else
                {
                    TableMatriz.Controls.Clear();
                    for (int f = 0; f < tamaño; f++)
                    {
                        TableRow fila = new TableRow();
                        for (int c = 0; c < tamaño; c++)
                        {
                            TableCell celda = new TableCell();
                            if (f + c == tamaño - 1)
                            {
                                celda.Text = "1";
                            }
                            else
                            {
                                celda.Text = "0";
                            }
                            fila.Cells.Add(celda);
                        }
                        TableMatriz.Rows.Add(fila);
                    }
                }
            }catch (Exception ex)
            {
                TableMatriz.Controls.Add(mensajeError(ex.Message));
            }
        }

        private TableRow mensajeError(string mensaje)
        {
            TableMatriz.Controls.Clear();
            TableRow fila = new TableRow();
            TableCell celda = new TableCell();
            celda.ColumnSpan = 1;
            celda.Text = mensaje;
            fila.Cells.Add(celda);
            TableMatriz.Controls.Add(fila);
            return fila;
        }
    }
}