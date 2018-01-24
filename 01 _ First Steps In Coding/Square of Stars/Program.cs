using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            // input data
            var n = int.Parse(Console.ReadLine());

            // up horizontal
            Console.WriteLine(new string('*', n));

            // verticals
            for (int a = 2; a < n; a++)
            {
                Console.Write("*");
                Console.Write(new string(' ' , n - 2));
                Console.WriteLine("*");
            }
            // down horizontal
            if (n > 1)
            {
                Console.WriteLine(new string('*', n));

            }

        }
    }
}
