using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {

            int intBegin = int.Parse(Console.ReadLine());
            int intEnd = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            var count = 0;

            for (int num1 = intBegin; num1 >= intEnd; num1--)
            {
                for (int num2 = intBegin; num2 >= intEnd; num2--)
                {
                    count++;
                    if (num1 + num2 == magicalNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({num1} + {num2} = {magicalNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
        }
    }
}
