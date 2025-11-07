using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int n1, n2, resultado;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            resultado = n1 + n2;
            Label4.Text = resultado.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            n2 = Convert.ToInt32(TextBox2.Text);
        }
    }
}