using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1 = char.Parse(Console.ReadLine());
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());
            char l4 = char.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            var counter = -1;

            for (int i1 = 'A'; i1 <= l1; i1++)
            {
                for (int i2 = 'a'; i2 <= l2; i2++)
                {
                    for (int i3 = 'a'; i3 <= l3; i3++)
                    {
                        for (int i4 = 'a'; i4 <= l4; i4++)
                        {
                            for (int i5 = 0; i5 <= n5; i5++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
