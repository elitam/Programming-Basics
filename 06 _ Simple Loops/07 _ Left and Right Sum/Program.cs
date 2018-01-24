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
                int sumNum = int.Parse(Console.ReadLine());
                sum1 += sumNum;
            }
            for (int i = 0; i < countNum; i++)
            {
                int sumNum = int.Parse(Console.ReadLine());
                sum2 += sumNum;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum1 - sum2));
            }

        }
    }
}
