using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            //           @        @        @
            //           **       *       **
            //           *.*     *.*     *.*
            //           *..*   *...*   *..*
            //           *...* *.....* *...*
            //           *....*.......*....*
            //           *.....***.***.....*
            //           *******************
            //           *******************

            int n = int.Parse(Console.ReadLine());
            var width = 2 * n - 1;
            var hight = n / 2 + 4;
            var spaces = n - 2;
            var spacesString = new string(' ', spaces);
            var dots = "";

            Console.WriteLine($"@{spacesString}@{spacesString}@");  // first line

            spaces--;
            spacesString = new string(' ', spaces);
            Console.WriteLine($"**{spacesString}*{spacesString}**");    // second line

            for (int i = 1; i <= n / 2 - 1; i++)    // middle lines
            {
                dots = new string('.', i);
                var middleDots = new string('.', i * 2 - 1);
                spaces -= 2;
                spacesString = new string(' ', Math.Max(spaces, 0));

                if (i == n / 2 - 1)
                {
                    middleDots += n % 2 == 0 ? "" : "..";
                    Console.WriteLine($"*{dots}*{middleDots}*{dots}*");
                }
                else
                {
                    Console.WriteLine($"*{dots}*{spacesString}*{middleDots}*{spacesString}*{dots}*");
                }
            }
            var middleDotsStr = new string('*', ((width - n - 3) / 2));
            middleDotsStr += n % 2 == 0 ? "" : "*";
            Console.WriteLine($"*{new string('.', n / 2)}{middleDotsStr}.{middleDotsStr}{new string('.', n / 2)}*");   // fucking line

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string('*', 2 * n - 1));
            }
        }
    }
}
