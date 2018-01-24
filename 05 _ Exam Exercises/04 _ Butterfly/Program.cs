using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            //        n = 5              ***\ /***       
            //                           ---\ /---
            //                           ***\ /***
            //                               @
            //                           ***/ \***
            //                           ---/ \---
            //                           ***/ \***


            int n = int.Parse(Console.ReadLine());
            var rows = 2 * (n - 2);

            for (int i = 0; i <= rows; i++)
            {
                var slash = i >= n - 1 ? "/ \\" : "\\ /";
                var stars = new string('*', n - 2);
                var tires = new string('-', n - 2);
                if (i == n - 2)
                {
                    var spaces = new string(' ', n - 1);
                    Console.WriteLine(spaces + "@" + spaces);

                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(stars + slash + stars);
                }
                else
                {
                    Console.WriteLine(tires + slash + tires);
                }

            }

        }
    }
}
