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
                case 1: outputText = "Monday"; break;
                case 2: outputText = "Tuesday"; break;
                case 3: outputText = "Wednesday"; break;
                case 4: outputText = "Thursday"; break;
                case 5: outputText = "Friday"; break;
                case 6: outputText = "Saturday"; break;
                case 7: outputText = "Sunday"; break;


                default:
                    outputText = "Error";
                    break;
            }
            Console.WriteLine(outputText);
        }
    }
}
