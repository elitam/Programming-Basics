using System;

namespace Even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var number = int.Parse(Console.ReadLine());
            var reminder = number % 2;
            var isNumberEven = reminder == 0;

            // print
            if (isNumberEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
