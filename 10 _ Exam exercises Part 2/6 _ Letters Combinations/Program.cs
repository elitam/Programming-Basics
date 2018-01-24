using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());
            var counter = 0;

            for (char i1 = begin; i1 <= end; i1++)
            {
                for (char i2 = begin; i2 <= end; i2++)
                {
                    for (char i3 = begin; i3 <= end; i3++)
                    {
                        if (i1 != exeption && i2 != exeption && i3 != exeption)
                        {
                            Console.Write($"{i1}{i2}{i3} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
