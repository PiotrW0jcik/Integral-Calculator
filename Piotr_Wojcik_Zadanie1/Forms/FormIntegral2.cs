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
 
    public partial class FormIntegral2 : Form
    {
        private double zValue;

        public FormIntegral2()
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
         
        }

        private void FormIntegral2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_out.Items.Clear();

            double correctVal = ((double)1 / 4 * Math.Pow(100, 4)) - ((double)1 / 4 * Math.Pow(0, 4));
            double maxCorrectVal = (correctVal * (100 + zValue)) / 100;
            double minCorrectVal = (correctVal * (100 - zValue)) / 100;

            RectangleMethod rectangleMethod = new RectangleMethod();
            SingleCount rectangle = new SingleCount(0, 100, 1, AreaType.Rectangle, 0, 0);
            rectangle = rectangleMethod.calculateArea(rectangle, 3);

            TrapezoidMethod trapezoidMethod = new TrapezoidMethod();
            SingleCount trapezoid = new SingleCount(0, 100, 1, AreaType.Trapezoid, 0, 0);
            trapezoid = trapezoidMethod.calculateArea(trapezoid, 3);

            Console.WriteLine(minCorrectVal + " " + correctVal + " " + maxCorrectVal + " " + rectangle.area);

            if (zValue > 0.005)
            { // zeby sie nie zapetlilo w razie za malej wartosci
                while (rectangle.area < minCorrectVal || rectangle.area > maxCorrectVal)
                {
                    rectangle.n += 1;
                    rectangle.area = 0;
                    rectangle = rectangleMethod.calculateArea(rectangle, 3);
                    Console.WriteLine(minCorrectVal + " " + correctVal + " " + maxCorrectVal + " " + rectangle.area + " " + rectangle.n);
                }

                while (trapezoid.area < minCorrectVal || trapezoid.area > maxCorrectVal)
                {
                    trapezoid.n += 1;
                    trapezoid.area = 0;
                    trapezoid = trapezoidMethod.calculateArea(trapezoid, 3);

                    Console.WriteLine(minCorrectVal + " " + correctVal + " " + maxCorrectVal + " " + trapezoid.area + " " + trapezoid.n);
                }
                result_out.Items.Add("Rectangle n=" + rectangle.n + " value=" + rectangle.area);
                result_out.Items.Add("Trapezoid n=" + trapezoid.n + " value=" + trapezoid.area);
            }
        }
    }
}

