﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string type = "";
            switch (animal)
            {
                case "dog":
                    type = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    type = "reptile";
                    break;
                default:
                    type = "unknown";
                    break;
            }
            Console.WriteLine(type);
        }
    }
}
