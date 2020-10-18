using System;

namespace GeometryLibrary
{
    public class Square : IFigureBase
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!!!");
                }
                else
                {
                    side = value;
                }
            }
        }

        public double CalculateAveragePerimetr()
        {
            return side * 2;
        }

        public double CalculateArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
