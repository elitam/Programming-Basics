using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("r = ");
            var radius = double.Parse(Console.ReadLine());

            // calc Area and Perimeter
            var area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            var perimeter = Math.Round(2 * Math.PI * radius, 2);

            // print
            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);


        }
    }
}
