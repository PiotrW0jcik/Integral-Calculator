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
    public partial class FormIntegral5 : Form
    {
        private int k;
        public FormIntegral5()
        {
            InitializeComponent();
        }

        private void k_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(k_input.Text, out k))
                k_input.Text = "";
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            float true_result = 1000000 / 3;
            result_out.Text = "";
            double n = int.Parse(k_input.Text);
            n = Math.Pow(10, n);

            Random rnd = new Random();

            double f = 0.0F;

            SingleCount single = new SingleCount();
            single.x1 = 0;
            single.x2 = 100;
            double f2 = 0.0F;
            for (int j = -10; j < 10; j++)
            {
                for (int j2 = -10; j2 < 10; j2++)
                {
                    single.x1 = j;
                    single.x2 = j2;
                    f = 0.0F;
                    f2 = 0.0F;
                    int licz = 0;
                    double old_i = 0;

                    for (double i = single.x1; i <= single.x2; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (i * i) * (i - old_i);

                        old_i = i;
                    };
                    for (double i = single.x1; i <= single.x2; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (i * i * i) * (i - old_i);

                        old_i = i;
                    };

                    if (f == f2)
                    {
                        string result = " rectangle method   x1 = " + single.x1.ToString() + " x2 = " + single.x2.ToString();
                        result_out.Items.Add(result);
                    }

                    f = 0.0F;
                    f2 = 0.0F;
                    old_i = 0;
                    for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    old_i = 0;
                    for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (((i * i * i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    if (Math.Floor(f) == Math.Floor(f2))
                    {
                        string result = " trapezoid method   x1 = " + single.x1.ToString() + " x2 = " + single.x2.ToString();
                        result_out.Items.Add(result);
                    }
                };
            };
        }

            private void wynik_out_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormIntegral5_Load(object sender, EventArgs e)
        {

        }
    }
}
