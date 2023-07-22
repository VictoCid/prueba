using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitio6
{
    public partial class segunda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fondo = "class=\"fondo1\"";
            int l = 0;
            int j = 32, k = 125;
            ltTabla.Text = "<table border=\"1\">";
            ltTabla.Text += "<tr>";
            ltTabla.Text += "<th>Código</th>";
            ltTabla.Text += "<th>Caracter</th>";
            ltTabla.Text += "</tr>";
            for (int i = 32; i < 126; i++)
            {
                ltTabla.Text += "<tr "+ fondo +">";
                ltTabla.Text += "<td>"+ i.ToString() +"</td>";
                ltTabla.Text += "<td>"+ Convert.ToChar(i) +"</td>";
                //ltTabla.Text += "<td>" + (char)i + "</td>";
                ltTabla.Text += "</tr>";
                if(l==0)
                {
                    fondo="class=\"fondo2\"";
                    l++;

                }
                else
                {
                    fondo = "class=\"fondo1\"";
                    l = 0;
                }
            }
            ltTabla.Text += "</table>";

            ltTabla.Text += "<table border=\"1\">";
            ltTabla.Text += "<tr>";
            ltTabla.Text += "<th>Código</th>";
            ltTabla.Text += "<th>Caracter</th>";
            ltTabla.Text += "</tr>";
            while (j<126)
            {
                ltTabla.Text += "<tr>";
                ltTabla.Text += "<td>" + j.ToString() + "</td>";
                ltTabla.Text += "<td>" + Convert.ToChar(j) + "</td>";
                //ltTabla.Text += "<td>" + (char)i + "</td>";
                ltTabla.Text += "</tr>";
                j++;
            }


            ltTabla.Text += "</table>";


            ltTabla.Text += "<table border=\"1\">";
            ltTabla.Text += "<tr>";
            ltTabla.Text += "<th>Código</th>";
            ltTabla.Text += "<th>Caracter</th>";
            ltTabla.Text += "</tr>";
            do
            {
                ltTabla.Text += "<tr>";
                ltTabla.Text += "<td>" + k.ToString() + "</td>";
                ltTabla.Text += "<td>" + Convert.ToChar(k) + "</td>";
                //ltTabla.Text += "<td>" + (char)k + "</td>";
                ltTabla.Text += "</tr>";
                k--;
            } while (k>31);

            ltTabla.Text += "</table>";
        }
    }
}
