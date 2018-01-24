using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92___Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            var outputText = "";
            if (speed <= 10)
            {
                outputText = "slow";
            }
            else if (speed <= 50)
            {
                outputText = "average";
            }
            else if (speed <= 150)
            {
                outputText = "fast";
            }
            else if (speed <= 1000)
            {
                outputText = "ultra fast";
            }
            else
            {
                outputText = "extremely fast";
            }

            Console.WriteLine(outputText);
        }
    }
}
