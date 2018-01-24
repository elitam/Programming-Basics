using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            var biggerNum = Math.Max(firstNum, secondNum);

            Console.WriteLine(biggerNum);
            
        }
    }
}
