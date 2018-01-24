using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96___Numbers_0_to_100_in_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> oneDigit = new Dictionary<int, string>()
            {
                {0 , "" },
                {1,"one" },
                {2,"two" },
                {3,"three" },
                {4,"four" },
                {5,"five" },
                {6,"six" },
                {7,"seven" },
                {8,"eight" },
                {9,"nine" },
                {10,"ten" },
                {11,"eleven" },
                {12,"twelve" },
                {13,"thirteen" },
                {14,"fourteen" },
                {15,"fifteen" },
                {16,"sixteen" },
                {17,"seventeen" },
                {18,"eighteen" },
                {19,"nineteen" }
            };
            Dictionary<int, string> twoDigit = new Dictionary<int, string>()
            {
                {0,"" },
                {2,"twenty" },
                {3,"thirty" },
                {4,"forty" },
                {5,"fifty" },
                {6,"sixty" },
                {7,"seventy" },
                {8,"eighty" },
                {9,"ninety" },
                {10,"one hundred" }
            };

            //
            var num = int.Parse(Console.ReadLine());
            var outputString = "";

            // 
            if (num >= 10 && num < 20)
            {
                outputString = oneDigit[num];
            }
            else if (num>=0 && num<=100)
            {
                int deca = num / 10;
                int secondDigit = num % 10;
                var tire = (deca == 0 || secondDigit == 0) ? "" : " ";
                outputString = num == 0 ? "zero" : twoDigit[deca] + tire + oneDigit[secondDigit];
            }
            else
            {
                outputString = "invalid number";
            }

            Console.WriteLine(outputString);

        }
    }
}
