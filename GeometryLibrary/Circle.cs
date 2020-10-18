using System;

namespace GeometryLibrary
{
    public class Circle : IFigureBase
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!!!");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double CalculateAveragePerimetr()
        {
            return Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
