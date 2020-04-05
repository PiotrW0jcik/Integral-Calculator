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
    public partial class FormIntegral6 : Form
    {
        private int k, m;

        public FormIntegral6()
        {
            InitializeComponent();
        }
        private void k_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(k_input.Text, out k))
                k_input.Text = "";
        }

        private void m_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(m_input.Text, out m))
                m_input.Text = "";
        }

        private void wynik_out_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormIntegral6_Load(object sender, EventArgs e)
        {

        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            result_out.Items.Clear();
            Random rand = new Random();
            double correctVal_1 = ((double)1 / 3 * Math.Pow(100, 3)) - ((double)1 / 3 * Math.Pow(0, 3));
            double correctVal_2 = ((double)1 / 4 * Math.Pow(100, 4)) - ((double)1 / 4 * Math.Pow(0, 4));
            int n = (int)Math.Pow(10, k);

            double roznicaRect1 = 0, roznicaRect2 = 0, roznicaTrap1 = 0, roznicaTrap2 = 0;

            for (int i = 0; i < m; i++)
            {
                int x1 = rand.Next(0, 101);
                int x2 = rand.Next(0, 101);

                RectangleMethod rectangleMethod = new RectangleMethod();
                SingleCount rectangle1 = rectangleMethod.calculateArea(new SingleCount(x1, x2, n, AreaType.Rectangle, 0, 0), 2);
                SingleCount rectangle2 = rectangleMethod.calculateArea(new SingleCount(x1, x2, n, AreaType.Rectangle, 0, 0), 3);

                TrapezoidMethod trapezoidMethod = new TrapezoidMethod();
                SingleCount trapezoid1 = trapezoidMethod.calculateArea(new SingleCount(x1, x2, n, AreaType.Trapezoid, 0, 0), 2);
                SingleCount trapezoid2 = trapezoidMethod.calculateArea(new SingleCount(x1, x2, n, AreaType.Trapezoid, 0, 0), 3);

                if (i == 0)
                {
                    roznicaRect1 = Math.Abs(correctVal_1 - rectangle1.area);
                    roznicaRect2 = Math.Abs(correctVal_1 - rectangle2.area);
                    roznicaTrap1 = Math.Abs(correctVal_2 - trapezoid1.area);
                    roznicaTrap2 = Math.Abs(correctVal_2 - trapezoid2.area);
                }
                else
                {
                    double roznica = Math.Abs(correctVal_1 - rectangle1.area);
                    if (roznica < roznicaRect1) roznicaRect1 = roznica;
                    roznica = Math.Abs(correctVal_1 - rectangle2.area);
                    if (roznica < roznicaRect2) roznicaRect2 = roznica;

                    roznica = Math.Abs(correctVal_2 - trapezoid1.area);
                    if (roznica < roznicaTrap1) roznicaTrap1 = roznica;
                    roznica = Math.Abs(correctVal_2 - trapezoid2.area);
                    if (roznica < roznicaTrap2) roznicaTrap2 = roznica;
                }
            }
            result_out.Items.Add("Rectange for x^2 differenceMin=" + roznicaRect1);
            result_out.Items.Add("Rectange for x^3 differenceMin=" + roznicaRect2);
            result_out.Items.Add("Trapezoid for x^2 differenceMin=" + roznicaTrap1);
            result_out.Items.Add("Trapezoid for x^3 differenceMin=" + roznicaTrap2);
        }

    }
}
