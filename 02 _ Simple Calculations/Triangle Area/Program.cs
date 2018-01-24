using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // input data
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());

            // calc
            var triangleArea = a * h/ 2;

            // print
            Console.WriteLine("Triangle area = " + triangleArea);



        }
    }
}
