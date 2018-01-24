using System;

namespace Nums_in_words
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int num = int.Parse(Console.ReadLine());
            var outputText = "";

            //
            switch (num)
            {
                case 1: outputText = "one"; break;
                case 2: outputText = "two"; break;
                case 3: outputText = "three"; break;
                case 4: outputText = "four"; break;
                case 5: outputText = "five"; break;
                case 6: outputText = "six"; break;
                case 7: outputText = "seven"; break;
                case 8: outputText = "eight"; break;
                case 9: outputText = "nine"; break;

                default:
                    outputText = "number too big";
                    break;
            }
            Console.WriteLine(outputText);
        }
    }
}
