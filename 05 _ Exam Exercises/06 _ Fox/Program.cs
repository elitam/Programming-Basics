using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            //   7              *\-------------/*           
            //                  **\-----------/**
            //                  ***\---------/***
            //                  ****\-------/****
            //                  *****\-----/*****
            //                  ******\---/******
            //                  *******\-/*******
            //                  |***\*******/***|
            //                  |****\*****/****|
            //                  -\*************/-
            //                  --\***********/--
            //                  ---\*********/---
            //                  ----\*******/----
            //                  -----\*****/-----
            //                  ------\***/------
            //                  -------\*/-------


            int n = int.Parse(Console.ReadLine());
            var stars = 0;
            var tires = 0;
            var width = 2 * n + 3;

            // prints fox ears
            for (int i = 1; i <= n; i++)
            {
                stars = i;
                tires = width - stars * 2 - 2;

                var starsString = new string('*', stars);
                var tiresString = new string('-', tires);
                Console.WriteLine(starsString + "\\" + tiresString + "/" + starsString );
            }

            // prints fox eyes
            for (int i = 0; i < n / 3; i++)
            {
                var firstStars = n / 2 + i;
                var secondStars = width - firstStars * 2 - 4;

                var firstStarsString = new string('*', firstStars);
                var secondStarsString = new string('*', secondStars);

                Console.WriteLine("|" + firstStarsString + "\\" + secondStarsString + "/" + firstStarsString + "|");
            }

            //
            for (int i = 1; i <= n; i++)
            {
                tires = i;
                stars = width - tires * 2 - 2;

                var starsString = new string('*', stars);
                var tiresString = new string('-', tires);
                Console.WriteLine(tiresString + "\\" + starsString + "/" + tiresString);
            }
        }

    }
}
