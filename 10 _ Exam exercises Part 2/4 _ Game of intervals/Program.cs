using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Game_of_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            var result = 0.0;

            var counter1 = 0.0;
            var counter2 = 0.0;
            var counter3 = 0.0;
            var counter4 = 0.0;
            var counter5 = 0.0;
            var counter6 = 0.0;

            for (int i = 0; i < moves; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0 || num > 50)
                {
                    result /= 2;
                    counter6++;
                }
                else if (num >= 0 && num < 10)
                {
                    result += 0.2 * num;
                    counter1++;
                }
                else if (num < 20)
                {
                    result += 0.3 * num;
                    counter2++;
                }
                else if (num < 30)
                {
                    result += 0.4 * num;
                    counter3++;
                }
                else if (num < 40)
                {
                    result += 50;
                    counter4++;
                }
                else if (num <= 50)
                {
                    result += 100;
                    counter5++;
                }

            } // result and counters

            var perc1 = counter1 == 0 ? 0 : counter1 * 100 / moves;
            var perc2 = counter2 == 0 ? 0 : counter2 * 100 / moves;
            var perc3 = counter3 == 0 ? 0 : counter3 * 100 / moves;
            var perc4 = counter4 == 0 ? 0 : counter4 * 100 / moves;
            var perc5 = counter5 == 0 ? 0 : counter5 * 100 / moves;
            var perc6 = counter6 == 0 ? 0 : counter6 * 100 / moves;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {perc1:f2}%");
            Console.WriteLine($"From 10 to 19: {perc2:f2}%");
            Console.WriteLine($"From 20 to 29: {perc3:f2}%");
            Console.WriteLine($"From 30 to 39: {perc4:f2}%");
            Console.WriteLine($"From 40 to 50: {perc5:f2}%");
            Console.WriteLine($"Invalid numbers: {perc6:f2}%");


        }
    }
}
