using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Soft_Uni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            //                     ...............#...............
            //                     ............#######............
            //                     .........#############.........
            //                     ......###################......
            //                     ...#########################...
            //                     ###############################
            //                     |..#########################...
            //                     |.....###################......
            //                     |.....###################......
            //                     @.....###################......


            int n = int.Parse(Console.ReadLine());
            var nn = n * 2;
            var width = (nn - 1) * 6 + 1;
            var hight = 4 * n - 2;
            var hatBase = n * 6 + 1;
            var hatSymbol = 1;

            for (int i = 0; i < hight; i++)
            {
                var symbolString = new string('#', hatSymbol);

                var points = (width - hatSymbol) / 2;
                var pointsStringRight = new string('.', points);
                var pointsStringLeft = "";

                if (i >= nn)
                {
                    pointsStringLeft += i == hight - 1 ? "@" : "|";
                    pointsStringLeft += new string('.', points - 1);

                }
                else
                {
                    pointsStringLeft = pointsStringRight;
                }
                hatSymbol += i >= nn - 1 ? -6 : 6;
                hatSymbol = i >= nn - 1 ? Math.Max(hatBase, hatSymbol) : hatSymbol;



                Console.WriteLine(pointsStringLeft + symbolString + pointsStringRight);

            }

        }
    }
}
