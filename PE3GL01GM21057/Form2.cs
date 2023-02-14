using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE3GL01GM21057
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double[] totals = new double[3];
        string[]compras=new string[3];
        private static int contador;
        private void buttonCodigoCompra_Click(object sender, EventArgs e)
        {
            double suma = 0;
            double porc = 0, porcEmpleado = 0;
            double total = 0;
            double comision = 0;
            if (textBoxCodigoCompra.Text.Equals("S01101"))
            {
                for (int i = 0; i < totals.Length; i++)
                {
                    suma += totals[i];
                }
                porc = (25 * suma) / 100;
                total = suma-porc;

            } else if (textBoxCodigoCompra.Text.Equals("I01023"))
            {
                for (int i = 0; i < totals.Length; i++)
                {
                    suma += totals[i];
                }
                porc = (13 * suma) / 100;
                total = suma + porc;

            }
            else
            {
                MessageBox.Show("Debe ingresar codigo Compra", "Error");
            }
            if (textBoxCodigoEmpleado.Equals("E12321")) {
                porcEmpleado = (9 * total) / 100;
                comision =total- porcEmpleado;

            }
            MessageBox.Show("Total de la compra:" + total + ", Comision del empleado: "+comision,"Factura");
        }

        private void buttonAgregarManzana_Click(object sender, EventArgs e)
        {
            try
            {
                if (contador < 3)
                {
                    totals[contador] = 1.00;
                    compras[contador] = "Manzana";
                    contador++;
                }
                else
                {
                    MessageBox.Show("Limite de compra es 3", "Error");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(" "+a.Message,"Error");
            }
           
            
           
        }

        private void buttonAgregarPera_Click(object sender, EventArgs e)
        {
            try
            {
                if (contador < 3)
                {
                    totals[contador] = 2.00;
                    compras[contador] = "Peras";
                    contador++;
                }
                else
                {
                    MessageBox.Show("Limite de compra es 3", "Error");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a.Message, "Error");
            }
           
        }
    }
}
