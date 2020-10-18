using System;
using GeometryLibrary;

namespace GeometryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius:");
            Circle circle = new Circle();
            circle.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle area ={circle.CalculateArea()}");
            Console.WriteLine($"Average circle permiter ={circle.CalculateAveragePerimetr()}");
         

            Console.WriteLine("Enter sqaure side:");
            Square square = new Square();
            square.Side = double.Parse(Console.ReadLine());
            Console.WriteLine($"Square area ={square.CalculateArea()}");
            Console.WriteLine($"Average square permiter ={square.CalculateAveragePerimetr()}");

            Console.WriteLine("Enter the sides of the trapezoid:");
            Trapezoid trapezoid = new Trapezoid();
            Console.WriteLine("Enter the top base:");
            trapezoid.Top = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the right, left side:");
            trapezoid.Right_left = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bottom base:");
            trapezoid.Bottom = double.Parse(Console.ReadLine());
            Console.WriteLine($"Trapezoid area ={trapezoid.CalculateArea()}");
            Console.WriteLine($"Average trapezoid permiter ={trapezoid.CalculateAveragePerimetr()}");

            FindMaxArea(new IFigureBase[] { circle, square, trapezoid });
            FindMaxPermiteterArea(new IFigureBase[] { circle, square, trapezoid });

            Console.ReadKey();
        }

        static void FindMaxArea(IFigureBase[] figures) 
        {
            double maxArea = 0;
            IFigureBase maxFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                double figureArea = figures[i].CalculateArea();
                if (figureArea > maxArea)
                {
                    maxArea = figureArea;
                    maxFigure = figures[i];
                }
            }

            Console.WriteLine($"Max area = {maxArea} and figure type = {maxFigure.GetType().Name}");
        }

        static void FindMaxPermiteterArea(IFigureBase[] figures)
        {
            double maxPermiter = 0;
            IFigureBase maxFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                double figureArea = figures[i].CalculateAveragePerimetr();
                if (figureArea > maxPermiter)
                {
                    maxPermiter = figureArea;
                    maxFigure = figures[i];
                }
            }

            Console.WriteLine($"Max average permiter = {maxPermiter} and figure type = {maxFigure.GetType().Name}");
        }
    }
}
