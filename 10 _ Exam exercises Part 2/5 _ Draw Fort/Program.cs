using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            //   /^^\__/^^\    
            //   |        |            
            //   |        |              
            //   |   __   |            
            //   \__/  \__/            

            int n = int.Parse(Console.ReadLine());
            var width = n * 2;
            var middleShit = n > 4 ? width - 2 * (n / 2) - 4 : 0;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', middleShit));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i != n - 2)
                {
                    Console.WriteLine("|{0}|", new string(' ', width - 2));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', middleShit));
                }
            }

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', middleShit));
        }
    }
}
