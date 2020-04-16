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
    public partial class FormIntegral8 : Form
    {
        private double zValue = 0;
        public FormIntegral8()
        {
            InitializeComponent();
        }

        private void z_input_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(z_input.Text, out zValue))
                z_input.Text = "";

        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            if (zValue > 0)
            {
                result_out.Items.Clear();
                RectangleMethod rectangleMethod = new RectangleMethod();
                TrapezoidMethod trapezoidMethod = new TrapezoidMethod();

                double xMax = Math.PI / 2;
                double correctVal = Math.Sin(xMax) - Math.Sin(0);
                double maxCorrectVal = (correctVal * (100 + zValue)) / 100;
                double minCorrectVal = (correctVal * (100 - zValue)) / 100;

                SingleCount rectangle = rectangleMethod.calculateArea(new SingleCount(0, xMax, 1, AreaType.Rectangle, 0, 0));
                SingleCount trapezoid = trapezoidMethod.calculateArea(new SingleCount(0, xMax, 1, AreaType.Trapezoid, 0, 0));

                while (rectangle.area <= minCorrectVal || rectangle.area >= maxCorrectVal)
                {
                    rectangle.area = 0;
                    rectangle.n++;
                    rectangle = rectangleMethod.calculateArea(rectangle);
                    trapezoid.area = 0;
                    trapezoid.n++;
                    trapezoid = trapezoidMethod.calculateArea(trapezoid);
                }

                result_out.Items.Add("Minimum N=" + rectangle.n);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zadanie8_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
