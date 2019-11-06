using System;

namespace dynamicPolymorphism
{
    //public const double PI;
    abstract class Shape
    {
        public abstract double area();
        public abstract double perimeter();
    }

    class Rectangle: Shape
    {
        public static int counter = 0;
        private int length;
        private int width;

        public Rectangle()
        {
            counter++;
            Console.WriteLine("The number of Rectangle:{0} ", counter);
        }

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override double area( )
        {
            //throw new NotImplementedException();
            Console.WriteLine("Rectangle Class Area: ");
            return (width * length);
        }
        public override double perimeter()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Rectangle Class Perimeter: ");
            return (2 * (length + width));

        }

        


    }

    class Triangle : Shape
    {
        private int baseT;
        private int height;
        public static int counter = 0;

        public Triangle()
        {
            counter++;
            Console.WriteLine("The number of Triangle:{0} ", counter);
        }

        public Triangle(int bT=0, int h=0)
        {
            baseT = bT;
            height = h;
        }

        public override double area()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Area of Triangle: ");
            return (0.5*(baseT * height));
        }

        public override double perimeter()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Perimeter of Triangle: ");
            return (height+ baseT + Math.Sqrt((baseT*baseT)+(height*height)));
        }
    }

    class Circle : Shape
    {
        private int radius;
        public static int counter = 0;

        public Circle()
        {
            counter++;
            Console.WriteLine("The number of Circle:{0} ", counter);
        }

        public Circle(int r)
        {
            radius = r;
        }

        public override double area()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Area of a Circle: ");
            return (Math.PI * (radius*radius));

        }

        public override double perimeter()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Perimeter of Circle: ");
            return (2 * Math.PI * radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfRectangle, breadthOfRectangle;
            lengthOfRectangle = Convert.ToInt32(Console.ReadLine());
            breadthOfRectangle = Convert.ToInt32(Console.ReadLine());

            

            Rectangle r = new Rectangle(lengthOfRectangle, breadthOfRectangle);
            Rectangle r2 = new Rectangle(10, 7);
            Rectangle r1 = new Rectangle();
            Rectangle r3 = new Rectangle();
            double a = r.area();
            double g = r2.area();
            double h = r2.perimeter();
            double b = r.perimeter();
            Console.WriteLine("Area: {0}", a);
            Console.WriteLine("Perimeter: {0}", b);

            Triangle T = new Triangle(10, 7);
            Triangle T1 = new Triangle();
            double c = T.area();
            double d = T.perimeter();
            Console.WriteLine("Area: {0}", c);
            Console.WriteLine("Perimeter: {0}", d);

            Circle C = new Circle(10);
            Circle C1 = new Circle();
            double e = C.area();
            double f = C.perimeter();
            Console.WriteLine("Area: {0}", c);
            Console.WriteLine("Perimeter: {0}", d);



            Console.ReadKey();
        }
    }
}
