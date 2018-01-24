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
            int maxNum = Int32.MinValue;
            for (int i = 0; i < countNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                maxNum = Math.Max(num, maxNum);

            }
            Console.WriteLine(maxNum);
        }
    }
}
