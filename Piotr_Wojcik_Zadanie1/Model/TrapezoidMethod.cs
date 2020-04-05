using System;
using System.Collections.Generic;
using System.Text;

namespace Piotr_Wojcik_Zadanie1.Model
{
    class TrapezoidMethod
    {
        public TrapezoidMethod() { }

        public SingleCount calculateArea(SingleCount model, int n)
        {

            double point = (double)model.x1;
            double dist = ((double)model.x2 / model.n); ;
            for (int i = 0; i < model.n; i++)
            {
                double d1 = Math.Pow(point += dist, n);
                double d2 = Math.Pow(point, n);
                double area = ((d1 + d2) * dist) / 2;
                model.area += area;
            }

            return model;
        }


        public SingleCount calculateArea(SingleCount model)
        {

            double point = (double)model.x1;
            double dist = ((double)model.x2 / model.n); ;
            for (int i = 0; i < model.n; i++)
            {
                double d1 = Math.Cos(point += dist);
                double d2 = Math.Cos(point);
                double area = ((d1 + d2) * dist) / 2;
                model.area += area;
            }

            return model;
        }
    }
}
