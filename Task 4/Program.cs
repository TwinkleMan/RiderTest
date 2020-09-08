using System;

namespace Task_4
{
    class Point
    {
        private int x, y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        
        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }

    class Figure
    {
        private Point point1, point2, point3, point4, point5;
        private double perimeter = 0;
        private string figureName;

        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4):this(point1, point2, point3)
        {
            this.point4 = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) : this(point1, point2,
            point3, point4)
        {
            this.point5 = point5;
        }

        public double SideLength(Point A, Point B)
        {
            double result;

            result = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            
            return result;
        }

        void PerimeterCount()
        {
            perimeter += SideLength(point1, point2);

            perimeter += SideLength(point2, point3);

            if (point4 == null)
            {
                perimeter += SideLength(point3, point1);
            }
            else if (point5 == null)
            {
                perimeter += SideLength(point3, point4);
                perimeter += SideLength(point4, point1);
            }
            else
            {
                perimeter += SideLength(point3, point4);
                perimeter += SideLength(point4, point5);
                perimeter += SideLength(point5, point1);
            }
        }

        private void CreateName()
        {
            figureName = point1.Name + point2.Name + point3.Name;

            if (point4 != null)
            {
                figureName += point4.Name;
                if (point5 != null)
                {
                    figureName += point5.Name;
                }
            }
        }

        public void Show()
        {
            CreateName();
            PerimeterCount();

            Console.WriteLine("Name of the figure: {0}", figureName);
            Console.WriteLine("Perimeter: {0}", Convert.ToString(perimeter));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int count = 1;
            int x, y;
            string name;
            string ans;

            Point point1 = null, point2 = null, point3 = null, point4 = null, point5 = null;

            Figure figure;

            while (flag)
            {
                Console.WriteLine("Enter point {0};", Convert.ToString(count));
                Console.Write("X = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                count++;
                if (point1 == null)
                {
                    point1 = new Point(x,y,name);
                } else if (point2 == null)
                {
                    point2 = new Point(x,y,name);
                } else if (point3 == null)
                {
                    point3 = new Point(x,y,name);
                    
                    Console.WriteLine("Do you want to create one more point? (Y/N)");
                    ans = Console.ReadLine();
                    if (ans == "N")
                    {
                        flag = false;
                    } else if (ans == "Y")
                    {
                        flag = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, shutting down...");
                        flag = false;
                    }
                    
                } else if (point4 == null)
                {
                    point4 = new Point(x,y,name);
                    
                    Console.WriteLine("Do you want to create one more point? (Y/N)");
                    ans = Console.ReadLine();
                    if (ans == "N")
                    {
                        flag = false;
                    } else if (ans == "Y")
                    {
                        flag = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input, shutting down...");
                        flag = false;
                    }
                    
                } else if (point5 == null)
                {
                    point5 = new Point(x,y,name);
                    flag = false;
                }
            }


            if (count < 3)
            {
                figure = new Figure(point1,point2,point3);
            } else if (count == 4)
            {
                figure = new Figure(point1,point2,point3,point4);
            }
            else
            {
                figure = new Figure(point1,point2,point3,point4,point5);
            }
            
            figure.Show();
        }
    }
}