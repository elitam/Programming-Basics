using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int begin = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            for (int i = begin; i >= end; i--)
            {
                if (i%2==0 && i%3==0 )
                {
                    if (i == stopNum)
                    {
                        return;
                    }
                    Console.Write($"{i} ");

                }

            }

        }
    }
}
