using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var secretCode = (500 + (code % 1000)) / 10;

            for (char i1 = 'a'; i1 <= 'z'; i1++)
            {
                for (char i2 = 'a'; i2 <= 'z'; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        for (char i4 = 'a'; i4 <= 'z'; i4++)
                        {
                            if (i1 != i2 && i1 + i2 + i3 - i4 == secretCode)
                            {
                                n--;
                                if (n == -1)
                                {
                                    return;
                                }
                                Console.Write($"{i1}{i2}{i3}{i4}");
                            }
                        }
                    }
                }
            }
        }
    }
}
