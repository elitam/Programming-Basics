﻿using System;


namespace Square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.Write("a= ");
            var a = int.Parse(Console.ReadLine());

            //
            var area = a * a;
            Console.WriteLine("Square area = " + area);
        }
    }
}
