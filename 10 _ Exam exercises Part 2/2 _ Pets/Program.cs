using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalFood = int.Parse(Console.ReadLine());
            double dogKgPerDay = double.Parse(Console.ReadLine());
            double catKgPerDay = double.Parse(Console.ReadLine());
            double turtleGrPerDay = double.Parse(Console.ReadLine());
            double turtleKgPerDay = turtleGrPerDay / 1000;

            var dogFood = dogKgPerDay * days;
            var catFood = catKgPerDay * days;
            var turtleFood = turtleKgPerDay * days;

            var petsWillEat = dogFood + catFood + turtleFood;

            if (totalFood >= petsWillEat)
            {
                Console.WriteLine($"{Math.Floor(totalFood - petsWillEat)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(petsWillEat - totalFood)} more kilos of food are needed.");
            }

        }
    }
}
