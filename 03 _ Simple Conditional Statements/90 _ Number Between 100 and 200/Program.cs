using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Number_Between_100_and_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var outputText = "";

            if (num > 200)
            {
                outputText = "Greater than 200";
            }
            else if (num >= 100)
            {
                outputText = "Between 100 and 200";
            }
            else 
            {
                outputText = "Less than 100";
            }

            Console.WriteLine(outputText);
        
        }
    }
}
