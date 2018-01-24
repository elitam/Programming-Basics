using System;

namespace _2D__Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // input data
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            // calc
            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y2 - y1);

            var area = width * height;
            var perimeter = 2 * (width + height);

            // print
            Console.WriteLine($"Area = \" {area} \"");
            Console.WriteLine($"Perimeter = {perimeter}");

        }
    }
}
