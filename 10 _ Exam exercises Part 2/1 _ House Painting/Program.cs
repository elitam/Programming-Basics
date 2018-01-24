using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            // sasho zvunq
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var walls = 2 * ((x * x - 1.2) + (x * y - 1.5*1.5));
            var roof = 2 * (x * y + x * h / 2);

            var greenPaint = walls / 3.4;
            var redPaint = roof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
