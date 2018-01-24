using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Foc
{
    class Program
    {
        static void Main(string[] args)
        {
            //  *\-------------/*       !! reads only odd numbers !!
            //  **\-----------/**
            //  ***\---------/***
            //  ****\-------/****
            //  *****\-----/*****
            //  ******\---/******
            //  *******\-/*******
            //  |***\*******/***|
            //  |****\*****/****|
            //  -\*************/-
            //  --\***********/--
            //  ---\*********/---
            //  ----\*******/----
            //  -----\*****/-----
            //  ------\***/------
            //  -------\*/-------

            int n = int.Parse(Console.ReadLine());
            var width = 2 * n + 3;
            var stars = n / 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', width - 2 * i - 2));
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', stars), new string ('*',width - 2 * stars - 4 ));
                stars++;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', width - 2 * i - 2));
            }
        }
    }
}
