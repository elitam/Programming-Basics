using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Money
{
    class Program
    {
        static void Main(string[] args)
        {
            //        •	1 биткойн = 1168 лева.
            //        •	1 китайски юан = 0.15 долара.
            //        •	1 долар = 1.76 лева.
            //        •	1 евро = 1.95 лева.



            int bitcoins = int.Parse(Console.ReadLine());
            var bitcoinsInLeva = bitcoins * 1168;
            var uana = double.Parse(Console.ReadLine());
            var uanaInLeva = uana * 0.15 * 1.76;
            var comission = double.Parse(Console.ReadLine());

            var allInEuro = (uanaInLeva + bitcoinsInLeva) / 1.95;
            var result = allInEuro - (comission / 100 * allInEuro);
            Console.WriteLine($"{result:f2}");
        }

    }
}
