using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Piotr_Wojcik_Zadanie1.Model;

namespace Piotr_Wojcik_Zadanie1.Forms
{
    public partial class FormIntegral7 : Form
    {
        
         private int x1, x2, z;

        public FormIntegral7()
        {
            InitializeComponent();
        }

        private void x1_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(x1_input.Text, out x1))
                x1_input.Text = "";
        }

        private void x2_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(x2_input.Text, out x2))
                x2_input.Text = "";
        }

        private void wynik_out_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormIntegral7_Load(object sender, EventArgs e)
        {

        }

        private void z_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(z_input.Text, out z))
                z_input.Text = "";
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            result_out.Items.Clear();
            RectangleMethod rectangleMethod = new RectangleMethod();
            TrapezoidMethod trapezoidMethod = new TrapezoidMethod();

            SingleCount rectangle = rectangleMethod.calculateArea(new SingleCount(x1, x2, 1, AreaType.Rectangle, 0, 0), 2);
            SingleCount trapezoid = trapezoidMethod.calculateArea(new SingleCount(x1, x2, 1, AreaType.Rectangle, 0, 0), 2);

            int rectInt = (int)rectangle.area;
            int trapInt = (int)trapezoid.area;

            while (!(rectInt % z == 0) && !(trapInt % z == 0) || rectangle.n > 10000)
            {
                rectangle.n++;
                rectangle.area = 0;
                trapezoid.n++;
                trapezoid.area = 0;
                rectangle = rectangleMethod.calculateArea(rectangle, 2);
                trapezoid = trapezoidMethod.calculateArea(trapezoid, 2);
                rectInt = (int)rectangle.area;
                trapInt = (int)trapezoid.area;
                Console.WriteLine(rectInt + " " + trapInt);
            }
            result_out.Items.Add("N=" + rectangle.n);
        }
    }
}
