using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            //      ......##################......      n = 6
            //      .......################.......
            //      ........##############........
            //      .........#..........#.........
            //      ..........#........#..........
            //      ...........#......#...........
            //      ............#....#............
            //      ............######............
            //      ..........##########..........
            //      ..........##########..........
            //      ..........##########..........
            //      ..........D^A^N^C^E^..........
            //      ..........##########..........
            //      ..........##########..........
            //      ..........##########..........
            //      ..........##########..........

            int n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var dots = n;
            var diez = n * 3;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', diez));
                dots++;
                diez -= 2;
            }

            var middleDots = width - 2 * dots - 2;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', middleDots));
                dots++;
                middleDots -= 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', dots - 1), new string('#', n));

            for (int i = 1; i <= n + 2; i++)
            {
                diez = n + 4;
                dots = (width - diez) / 2;
                if (i == n / 2 + 1)
                {
                    dots = (width - 10) / 2;
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', dots));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', dots), new string ('#', diez));
                }
            }
        }
    }
}
