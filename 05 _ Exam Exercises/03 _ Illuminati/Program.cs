using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var rows = n * 2;

            for (int i = 0; i <= n; i++)
            {
                var points = new string('.', i);
                var symbols = i == 0 ? rows : rows - i * 2 + 1;
                var symbolsString = new string('#', symbols);
                var spaces = Math.Max(i - (i == n / 2 + 1 ? 2 : 1), 0);
                var spacesString = new string(' ', spaces);
                var fuckingSymbol = i == 0 ? "#" : i == n / 2 + 1 ? "(@)" : " ";
                Console.WriteLine(points + symbolsString + spacesString + fuckingSymbol + spacesString + symbolsString + points);
            }
            for (int i = 0; i < n; i++)
            {
                var points = new string('.', i + (n + 1));
                var symbols = (rows - 1) - (i * 2);
                var symbolsString = new string('#', symbols);
                Console.WriteLine(points + symbolsString + points);

            }
        }

    }
}
