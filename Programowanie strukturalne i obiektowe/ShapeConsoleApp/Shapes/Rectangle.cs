using System;

namespace ShapeConsoleApp.Shapes
{
    class Rectangle
    {
        protected double sideA;
        protected double sideB;

        public Rectangle()
        {
            sideA = 21;
            sideB = 37;
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = Math.Abs(sideA);
            this.sideB = Math.Abs(sideB);
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return 2 * sideA + 2 * sideB;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacja o prostokącie");
            Console.WriteLine("Bok a = " + sideA);
            Console.WriteLine("Bok b = " + sideB);
            Console.WriteLine("Pole " + Area());
            Console.WriteLine("Obwód " + Perimeter());
        }
    }
}
