using System;

namespace Project1
{
    class Rectangle
    {
        private double side1, side2;
        public double Area { get; }
        public double Perimeter { get; }
           
        //new constructor
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        //counts the square of the rectangle
        double AreaCalculator()
        {
            return (side1 * side2);
        }
            
        //counts the perimeter of the rectangle
        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of your rectangle:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a,b);
            
            Console.WriteLine("The area of your rectangle is {0}; \nThe perimeter of it: {1}", 
                Convert.ToString(rectangle.Area), Convert.ToString(rectangle.Perimeter));

            Console.ReadKey();
        }
    }
}
