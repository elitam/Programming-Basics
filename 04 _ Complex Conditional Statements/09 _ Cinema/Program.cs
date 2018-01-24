using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectionType = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var colones = int.Parse(Console.ReadLine());
            var seats = rows * colones;
            var price =  0.0;

            switch (projectionType)
            {
                case "Premiere": price = seats * 12;break;
                case "Normal": price = seats * 7.5;break;
                case "Discount": price = seats * 5;break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2}", price);
        }
    }
}
