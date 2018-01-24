using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNum = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < countNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
                
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes \n\rSum = " + sum1);
            }
            else
            {
                Console.WriteLine("No \n\rDiff = " + Math.Abs(sum1 - sum2));
            }
        }
    }
}
