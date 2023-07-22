using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitio6
{
    public partial class tercera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fondo = "fondo1";
            TableHeaderCell enc1 = new TableHeaderCell();
            TableHeaderCell enc2 = new TableHeaderCell();

            enc1.Text = "Código";
            enc2.Text = "Caracter";

            TableHeaderRow thRow = new TableHeaderRow();
            thRow.Cells.Add(enc1);
            thRow.Cells.Add(enc2);

            tbAscii.Rows.Add(thRow); // Agregar encabezados th al thead

            tbAscii.GridLines = GridLines.Both;

            for (int i = 32; i < 126; i++)
            {
                TableRow fila = new TableRow(); // Fila para los datos
                fila.CssClass = fondo;

                TableCell celda1 = new TableCell();
                TableCell celda2 = new TableCell();
                celda1.Text = i.ToString();
                celda2.Text = ((char)i).ToString();

                // Agregar las celdas de datos td en la fila de datos
                fila.Cells.Add(celda1);
                fila.Cells.Add(celda2);
                tbAscii.Rows.Add(fila);

                TableRow thFila = new TableRow(); // Fila para los encabezados th intercalados


                // Agregar las celdas de encabezado th en la fila de encabezados
                TableCell thCelda1 = new TableCell();
                TableCell thCelda2 = new TableCell();
                thCelda1.Text = "Código";
                thCelda2.Text = "Caracter";
                thFila.Cells.Add(thCelda1);
                thFila.Cells.Add(thCelda2);
                tbAscii.Rows.Add(thFila);

                if (fondo.Equals("fondo1"))
                {
                    fondo = "fondo2";
                }
                else
                {
                    fondo = "fondo1";
                }
            }
        }

    }

    //  TableRow fila2;   
    // TableHeaderCell enc3 = new TableHeaderCell();
    // TableHeaderCell enc4 = new TableHeaderCell();
    // TableCell celda3, celda4;        
    // enc3.Text = "Código";
    // enc4.Text = "Caracter";
    // fila2 = new TableRow();
    // fila2.Cells.Add(enc3);
    // fila2.Cells.Add(enc4);
    // tbAscii.Rows.Add(fila2);
    // tbAscii.GridLines = GridLines.Both;
    //for (int i = 33; i < 126; i++)
    // {

    //   celda3 = new TableCell();
    // celda4 = new TableCell();

    // celda3.Text = i.ToString();
    // celda4.Text = ((char)i).ToString();
    //fila2 = new TableRow();
    //fila2.CssClass = fondo;               
    //fila2.Cells.Add(celda3);
    //fila2.Cells.Add(celda4);
    //tbAscii.Rows.Add(fila2);
    //if (fondo.Equals("fondo1"))
    //{
    //fondo = "fondo2";
    //}
    // else
    //{
    //fondo = "fondo1";
    //}
}