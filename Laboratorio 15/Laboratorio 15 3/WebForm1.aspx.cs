using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string texto = TextBox1.Text;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "MessageBox", "window.alert('Hola: " + texto + "');", true);
        }
    }
}