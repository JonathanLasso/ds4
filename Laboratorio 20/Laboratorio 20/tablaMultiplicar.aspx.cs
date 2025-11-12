using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20
{
    public partial class tablaMultiplicar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrearTabla_Click(object sender, EventArgs e)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(TxtEntradaNumero.Text);
                PhTabla.Controls.Clear();
                Table tabla = new Table();
                for(int i = 1; i <= 25; i++)
                {
                  TableRow fila = new TableRow();
                  TableCell celda = new TableCell();
                  celda.Text = $"{numero} x {i} = {numero * i}";
                  fila.Cells.Add(celda);
                  tabla.Rows.Add(fila);
                    
                }
                PhTabla.Controls.Add(tabla);
            }catch(Exception)
            {
                PhTabla.Controls.Clear();
                PhTabla.Controls.Add(new Literal { Text = "Por favor ingrese un numero valido." });
            }
        }

        protected void TxtEntradaNumero_TextChanged(object sender, EventArgs e)
        {
            if (TxtEntradaNumero.Text == "")
            {
                return;
            }
        }
    }
}