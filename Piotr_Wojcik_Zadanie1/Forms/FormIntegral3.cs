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
    public partial class FormIntegral3 : Form
    {
        private int x1;
        private int x2;

        public FormIntegral3()
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

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            results_out.Items.Clear();
            double correctVal = ((double)1 / 3 * Math.Pow(100, 3)) - ((double)1 / 3 * Math.Pow(0, 3));

            SingleCount rectangleSC = new SingleCount(x1, x2, 0, AreaType.Rectangle, 0, 0);
            SingleCount trapezoidSC = new SingleCount(x1, x2, 0, AreaType.Trapezoid, 0, 0);

            RectangleMethod rectangleMethod = new RectangleMethod();

            TrapezoidMethod trapezoidMethod = new TrapezoidMethod();

            for (int i = 1; i <= 7; i++)
            {
                int n = (int)Math.Pow(10, i);
                rectangleSC.n = n;
                rectangleSC = rectangleMethod.calculateArea(rectangleSC, 2);
                rectangleSC.minSquareError += Math.Pow(correctVal - rectangleSC.area, 2);

                trapezoidSC.n = n;
                trapezoidSC = trapezoidMethod.calculateArea(trapezoidSC, 2);
                trapezoidSC.minSquareError += Math.Pow(correctVal - trapezoidSC.area, 2);

            }

            results_out.Items.Add("Rectangle error = " + (rectangleSC.minSquareError / 6));
            results_out.Items.Add("Trapezoid error = " + (trapezoidSC.minSquareError / 6));

        }

        private void FormIntegral3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
