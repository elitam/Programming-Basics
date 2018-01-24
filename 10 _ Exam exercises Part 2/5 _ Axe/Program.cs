using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            //      ---------------**--------      
            //      ---------------*-*-------      
            //      ---------------*--*------      
            //      ---------------*---*-----      
            //      ---------------*----*----
            //      ****************----*----
            //      ****************----*----
            //      ---------------*----*----
            //      --------------********---

            int n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var leftDashes = 3 * n;
            var middleDashes = 0;
            var rightDashes = width - leftDashes - middleDashes - 1;

            for (int i = 0; i < n; i++)
            {
                middleDashes = i;
                rightDashes--;
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightDashes));
            }

            for (int k = 0; k < n / 2; k++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', middleDashes), new string('-', rightDashes));

            }
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightDashes));
                leftDashes--;
                middleDashes += 2;
                rightDashes--;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', middleDashes), new string('-', rightDashes));
        }
    }
}
