using System;
using System.Collections.Generic;
using System.Text;

namespace Piotr_Wojcik_Zadanie1.Model
{
    class RectangleMethod
    {
        public RectangleMethod() { }

        public SingleCount calculateArea(SingleCount model, int n)
        {
            double dist = ((double)model.x2 / model.n);
            double point = dist;
            for (int i = 0; i < model.n; i++)
            {
                double d = Math.Pow(point, n);
                double area = dist * d;
                point += dist;
                model.area += area;
            }

            return model;
        }

        public SingleCount calculateArea(SingleCount model)
        {
            double dist = ((double)model.x2 / model.n);
            double point = dist;
            for (double i = 0; i < model.n; i++)
            {
                double d = Math.Cos(point);
                double area = dist * d;
                point += dist;
                model.area += area;
            }

            return model;
        }
    }
}
