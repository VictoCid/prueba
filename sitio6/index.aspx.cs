using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitio6
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ltTabla.Text = "<h1>Hola mundo desde C#</h1>";
            ltTabla.Text += "otra linea de texto<br>";
            ltTabla.Text += "Tercera linea de texto<br><br>";

            ltTabla.Text += "Fecha: " + DateTime.Today.ToLongDateString();
            ltTabla.Text += "<br>Hora:" + DateTime.Now.ToShortTimeString();
            ltTabla.Text += "<br>Fecha: " + DateTime.Today.ToShortDateString();
            ltTabla.Text += "<br>Hora:" + DateTime.Now.ToLongTimeString();

        }
    }
}