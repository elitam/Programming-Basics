﻿using System;
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
            var sum = 0;
            for (int i = 0; i < countNum; i++)
            {
                int sumNum = int.Parse(Console.ReadLine());
                sum += sumNum;
            }
            Console.WriteLine(sum);
        }
    }
}
