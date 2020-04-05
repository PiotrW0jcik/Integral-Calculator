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
    public partial class FormIntegral4 : Form
    {
        private int x1, x2, kVal, zVal;

        public FormIntegral4()
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

        private void FormIntegral4_Load(object sender, EventArgs e)
        {

        }

        private void k_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(k_input.Text, out kVal))
                k_input.Text = "";
        }

        private void z_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(z_input.Text, out zVal))
                z_input.Text = "";
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            result_out.Items.Clear();

            double correctVal = ((double)1 / 4 * Math.Pow(100, 4)) - ((double)1 / 4 * Math.Pow(0, 4));

            RectangleMethod rectangleMethod = new RectangleMethod();
            SingleCount rectangle = new SingleCount(x1, x2, (int)Math.Pow(10, kVal), AreaType.Rectangle, 0, 0);
            rectangle = rectangleMethod.calculateArea(rectangle, 3);

            TrapezoidMethod trapezoidMethod = new TrapezoidMethod();
            SingleCount trapezoid = new SingleCount(x1, x2, (int)Math.Pow(10, kVal), AreaType.Trapezoid, 0, 0);
            trapezoid = trapezoidMethod.calculateArea(trapezoid, 3);

            int rectangleInt = (int)rectangle.area;
            int trapezoidInt = (int)trapezoid.area;
            if (rectangleInt % zVal == 0 && trapezoidInt % zVal == 0)
            {
                Console.WriteLine(rectangleInt + " " + trapezoidInt);
                result_out.Items.Add("Rectengle x1=" + x1 + " x2=" + x2);
                result_out.Items.Add("Trapezoid x1=" + x1 + " x2=" + x2);
            }
            else
                result_out.Items.Add("Podane wartości x1,x2,k nie spełniają warunku");
        }
    }
}

