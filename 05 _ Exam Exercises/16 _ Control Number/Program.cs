using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = m; i2 >= 1; i2--)
                {
                    counter++;
                    sum += i1 * 2 + i2 * 3;
                    if (sum >= controlNum)
                    {
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} moves");
        }
    }
}
