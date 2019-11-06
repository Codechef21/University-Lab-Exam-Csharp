using System;

namespace labexam2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // int[] arrayofNumbers;
            int [] arrayofNumbers = { 2,3,4,5,6,7,8,9};
            int total = Numbers.Multiply(arrayofNumbers);

            Console.WriteLine("The result: {0} ", total);
        }

       
        
    }

    public class Numbers
    {
        public static int Multiply(params int[] list)
        {
            int total = 1;
            foreach (int num in list)
            {
                total *= num;
            }

            return total;
        }
    }
}
