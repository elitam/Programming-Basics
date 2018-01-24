using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Chrismas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {

            //        #     
            //       ###
            //        #
            //       *~*
            //      *~~~*  
            //     *~~~~~*
            //    *~~~~~~~*
            //    *~~~~~~~~~*
            //    *~~~~~~~~~~~*
            //    ##############

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{new string(' ', n)}#");
            Console.WriteLine($"{new string(' ', n - 1)}###");
            Console.WriteLine($"{new string(' ', n)}#");
            var spaces = n;
            var waves = 1;

            for (int i = 0; i < n * 2; i++)
            {
                spaces -= spaces > 0 ? 1 : 0;
                Console.WriteLine($"{new string(' ', spaces)}*{new string('~', waves)}*");
                waves += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('#', n * 4 + 2));
            }
        }
    }
}
