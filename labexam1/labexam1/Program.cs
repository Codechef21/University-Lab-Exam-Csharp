using System;

namespace labexam1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double addition, subtraction, multiply, divide;

            Console.WriteLine("Enter the Value of a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            calculate(a, b, out addition, out subtraction, out multiply, out divide);

            Console.WriteLine("Addition: {0}", addition);
            Console.WriteLine("Subtraction: {0}", subtraction);
            Console.WriteLine("Multiplication: {0}", multiply);
            Console.WriteLine("Divide: {0}", divide);


        }

        public static void calculate(double a,double b, out double Addition, out double Subtraction, out double Multiply, out double divide)
        {

            Addition = a + b;
            Subtraction = a - b;
            Multiply = a * b;
            divide = a / b;
            

        }
    }
}
