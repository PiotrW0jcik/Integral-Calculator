using System;
using System.Collections.Generic;
using System.Text;

namespace Piotr_Wojcik_Zadanie1.Model
{
    public enum AreaType
    {
        Rectangle,
        Trapezoid
    }

    public class SingleCount
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public int n { get; set; }
        public AreaType areatType { get; set; }
        public double area { get; set; }
        public int calculationNumber { get; set; }
        public int lowestN { get; set; }
        public double minSquareError { get; set; }

        public SingleCount() { }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.n = n;
            this.areatType = areaType;
            this.area = area;
            this.calculationNumber = calcNumber;
        }

        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber, int lowestN)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.n = n;
            this.areatType = areatType;
            this.area = area;
            this.calculationNumber = calcNumber;
            this.lowestN = lowestN;
        }

        public class Global
        {
            public List<SingleCount> listOfSingleCount { get; set; }
            public Global() { }
            public Global(List<SingleCount> list)
            {
                this.listOfSingleCount = list;
            }
        }

    }
}
