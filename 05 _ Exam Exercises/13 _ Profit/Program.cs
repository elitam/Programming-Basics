using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int bgn1= int.Parse(Console.ReadLine());
            int bgn2= int.Parse(Console.ReadLine());
            int bgn5= int.Parse(Console.ReadLine());
            int bgnTotal= int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 <= bgn1; i1++)
            {
                for (int i2 = 0; i2 <= bgn2; i2++)
                {
                    for (int i5 = 0; i5 <= bgn5; i5++)
                    {
                        if (i1 * 1 + i2 * 2 + i5 * 5 == bgnTotal)
                        {
                            Console.WriteLine($"{i1} * 1 lv. + {i2} * 2 lv. + {i5} * 5 lv. = {bgnTotal} lv.");
                        }
                    }
                }
            }
        }
    }
}
