using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Swimming_World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double secRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double ivanchoSPM = double.Parse(Console.ReadLine());

            double slowing = Math.Floor(meters / 15) * 12.5;
            double ivanchoSecs = meters * ivanchoSPM + slowing;

            if (ivanchoSecs < secRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoSecs:f2} seconds.");
            }
            else
            {
                double diff = ivanchoSecs - secRecord;
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }
        }
    }
}
