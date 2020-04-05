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
    

    public partial class FormIntegral1 : Form
    {
        private double zValue;
        private int mValue;

        public FormIntegral1()
        {
            InitializeComponent();
        }


        private void m_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(m_input.Text, out mValue))
                m_input.Text = "";
        }


        private void z_input_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(z_input.Text, out zValue))
                z_input.Text = "";
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            rectangles_out.Items.Clear();
            trapezoid_out.Items.Clear();
            Random rand = new Random();

            for (int i = 0; i < mValue; i++)
            {
                int n = rand.Next(10, 100001);
                double correctVal = ((double)1 / 3 * Math.Pow(100, 3)) - ((double)1 / 3 * Math.Pow(0, 3));
                double maxCorrectVal = (correctVal * (100 + zValue)) / 100;
                double minCorrectVal = (correctVal * (100 - zValue)) / 100;

                SingleCount rectangleSC = new SingleCount(0, 100, n, AreaType.Rectangle, 0, 0);
                SingleCount trapezoidSC = new SingleCount(0, 100, n, AreaType.Trapezoid, 0, 0);

                RectangleMethod rectangleMethod = new RectangleMethod();
                rectangleSC = rectangleMethod.calculateArea(rectangleSC, 2);

                TrapezoidMethod trapezoidMethod = new TrapezoidMethod();
                trapezoidSC = trapezoidMethod.calculateArea(trapezoidSC, 2);

                if (rectangleSC.area >= minCorrectVal && rectangleSC.area <= maxCorrectVal)
                    rectangles_out.Items.Add(rectangleSC.areatType.ToString() + " => " + rectangleSC.area);
                if (trapezoidSC.area >= minCorrectVal && trapezoidSC.area <= maxCorrectVal)
                    trapezoid_out.Items.Add(trapezoidSC.areatType.ToString() + " => " + trapezoidSC.area);

                Console.WriteLine(minCorrectVal + " " + correctVal + " " + maxCorrectVal);
            }
        }

        private void prostakoty_out_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void trapezy_out_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormIntegral1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblZ_Click(object sender, EventArgs e)
        {

        }

        private void lblM_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
