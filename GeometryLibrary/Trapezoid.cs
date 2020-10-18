using System;

namespace GeometryLibrary
{
    public class Trapezoid : IFigureBase
    {
        private double top, bottom, right_left, height;

        public double Top
        {
            get
            {
                return top;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!");
                }
                else
                {
                    top = value;
                }
            }
        }

        public double Bottom
        {
            get
            {
                return bottom;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!");
                }
                else
                {
                   bottom = value;
                }
            }
        }

        public double Right_left
        {
            get
            {
                return right_left;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!");
                }
                else
                {
                    right_left = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double CalculateAveragePerimetr()
        {
            return (2 * right_left + top + bottom) / 2;
        }

        public double CalculateArea()
        {

            return (top + bottom) / 2 * height;
        }


    }
}
