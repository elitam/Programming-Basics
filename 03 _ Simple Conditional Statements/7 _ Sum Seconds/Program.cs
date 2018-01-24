using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var sumSeconds = a + b + c;

            var seconds = sumSeconds % 60;
            int minutes = sumSeconds / 60;

            // print
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);

            }

        }
    }
}
