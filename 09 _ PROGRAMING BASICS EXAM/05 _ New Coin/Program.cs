using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___New_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var spaces = n * 2;
            var spacesStr = new string(' ', spaces);

            var slash = n;
            var slashStr = new string('\\', slash);

            var backSlash = n;
            var backSlashStr = new string('/', backSlash);

            var tire = 6;
            var tireStr = new string('-', tire);

            Console.WriteLine($"{spacesStr}{slashStr}{backSlashStr}{spacesStr}");
            tire -= 6;
            for (int i = 0; i < n - 1; i++)
            {
                slash -= 1;
                slashStr = new string('\\', slash);

                backSlash -= 1;
                backSlashStr = new string('/', backSlash);

                tire += 6;
                tireStr = new string('-', tire);

                spaces -= 2;
                spacesStr = new string(' ', spaces);

                Console.WriteLine($"{spacesStr}{slashStr}{tireStr}{backSlashStr}{spacesStr}");
            } // first part
            for (int i = 1; i <= n / 4; i++)
            {
                var diez = n * 4;
                var diezStr = new string('#', diez);

                var midTire = n - 1;
                var midTireStr = new string('-', midTire);

                Console.WriteLine($"|{midTireStr}{diezStr}{midTireStr}|");
            } // diez line

            var midSlash = new string('/', n + n - 3);
            var waves = new string('~', n - 1);
            var midSlashBack = new string('/', n + n - 3);
            Console.WriteLine($"|{waves}{midSlash} ESTD {midSlashBack}{waves}|");

            for (int i = 1; i <= n / 4; i++)
            {
                var diez = n * 4;
                var diezStr = new string('#', diez);

                var midTire = n - 1;
                var midTireStr = new string('-', midTire);

                Console.WriteLine($"|{midTireStr}{diezStr}{midTireStr}|");
            } // diez line 2

            spaces = 0;
            tire = (n - 1) * 6 + 6;

            for (int i = 1; i <= n - 1; i++)
            {
                slash = i;
                slashStr = new string('/', slash);

                backSlash = i;
                backSlashStr = new string('\\', backSlash);

                spaces += 2;
                spacesStr = new string(' ', spaces);

                tire -= 6;
                tireStr = new string('-', tire);

                Console.WriteLine($"{spacesStr}{slashStr}{tireStr}{backSlashStr}{spacesStr}");
            } // second part

            spacesStr = new string(' ', n * 2);
            slashStr = new string('\\', n);
            backSlashStr = new string('/', n);
            Console.WriteLine($"{spacesStr}{backSlashStr}{slashStr}{spacesStr}");

        }
    }
}
