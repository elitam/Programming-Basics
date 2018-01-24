using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___New_Year_Wondering
{
    class Program
    {
        static void Main(string[] args)
        {


            var city = Console.ReadLine();
            var transport = Console.ReadLine();
            var bagage = Console.ReadLine();
            var hoursToNY = double.Parse(Console.ReadLine());
            var transportHours = 0.0;

            if (transport == "Car")
            {
                if (city == "Sofia")
                {
                    transportHours = 3;
                }
                else if (city == "Plovdiv")
                {
                    transportHours = 4.8;
                }
                else if (city == "Bansko")
                {
                    transportHours = 2.5;
                }
            }
            else if (transport == "Train")
            {
                if (city == "Sofia")
                {
                    transportHours = 4.5;
                }
                else if (city == "Plovdiv")
                {
                    transportHours = 7;
                }
                else if (city == "Bansko")
                {
                    transportHours = 4;
                }
            }
            else if (transport == "Foot")
            {
                if (city == "Sofia")
                {
                    transportHours = 55.5;
                }
                else if (city == "Plovdiv")
                {
                    transportHours = 85;
                }
                else if (city == "Bansko")
                {
                    transportHours = 43;
                }
            }
            else if (transport == "Bus")
            {
                if (city == "Sofia")
                {
                    transportHours = 3.7;
                }
                else if (city == "Plovdiv")
                {
                    transportHours = 6.5;
                }
                else if (city == "Bansko")
                {
                    transportHours = 3.2;
                }
            }

            if (bagage == "Backpack")
            {
                transportHours += 0.03 * transportHours;
            }
            else if (bagage == "Sack")
            {
                transportHours += 0.1 * transportHours;
            }
            else if (bagage == "None")
            {
                transportHours -= 0.08 * transportHours;
            }

            var hoursLeft = Math.Abs(hoursToNY - transportHours);

            if (transportHours > hoursToNY)
            {
                Console.WriteLine($"Oh no, Stoyan is late. New year's evening started {hoursLeft:f1} hours ago.");

            }
            else 
            {
                Console.WriteLine($"{hoursLeft:f1} Hours left until New Year's evening.");

            }

        }
    }
}
