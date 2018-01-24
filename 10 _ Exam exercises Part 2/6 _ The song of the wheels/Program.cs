using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());
            string fourthNum = "";
            var counter = 0;

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (i1 * i2 + i3 * i4 == controlNum && i1 < i2 && i3 > i4)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                                counter++;
                                if (counter == 4)
                                {
                                    fourthNum = $"{i1}{i2}{i3}{i4}";
                                }
                            }
                        }
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine(fourthNum != "" ? $"Password: {fourthNum}" : "No!");
        }
    }
}
