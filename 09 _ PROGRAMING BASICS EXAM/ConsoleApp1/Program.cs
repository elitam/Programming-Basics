using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        for (int i4 = 'a'; i4 <= 'z'; i4++)
                        {
                            for (int i5 = 'a'; i5 <= 'z'; i5++)
                            {
                                for (int i6 = 0; i6 <= 9; i6++)
                                {
                                    var sum = i1 + i2 + i3 + i4 + i5 + i6;
                                    if (sum == pass)
                                    {
                                        counter++;
                                        if (counter <= count)
                                        {
                                            Console.Write($"{i1}{i2}{i3}{(char)i4}{(char)i5}{i6} ");
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
