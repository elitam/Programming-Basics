using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int numCount = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < numCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
                var p1Percentage = p1 / numCount * 100;
                var p2Percentage = p2 / numCount * 100;
                var p3Percentage = p3 / numCount * 100;
                var p4Percentage = p4 / numCount * 100;
                var p5Percentage = p5 / numCount * 100;

                Console.WriteLine($"{p1Percentage:f2}%");
                Console.WriteLine($"{p2Percentage:f2}%");
                Console.WriteLine($"{p3Percentage:f2}%");
                Console.WriteLine($"{p4Percentage:f2}%");
                Console.WriteLine($"{p5Percentage:f2}%");
            
        }
    }
}
