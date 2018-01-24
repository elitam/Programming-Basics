using System;

namespace Snow_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants
            var trackLenghtInMeters = 2300;
            var trackTimeInMin = 8;

            // input
            Console.Write("How much time are you gonna ride(minutes)?: ");
            var min = int.Parse(Console.ReadLine());

            // calc
            double downs = (min / trackTimeInMin);
            var meters = downs * trackLenghtInMeters;

            // print
            Console.WriteLine("You are gonna make {0} downs and {1} meters!", downs, meters);
        }
    }
}
