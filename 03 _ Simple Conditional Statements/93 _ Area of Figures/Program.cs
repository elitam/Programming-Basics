using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93___Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            var figure = Console.ReadLine();
            var area = 0.000;

            //
            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                area = Math.Pow(sideA, 2);
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (sideA * h) / 2;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
            }

            // print
            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
