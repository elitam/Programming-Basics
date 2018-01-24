using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWord = Console.ReadLine();

            if (inputWord == "banana" || inputWord == "apple" || inputWord == "kiwi" || inputWord == "cherry"
                || inputWord == "lemon" || inputWord == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (inputWord == "tomato" || inputWord == "cucumber" || inputWord == "pepper" || inputWord == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
