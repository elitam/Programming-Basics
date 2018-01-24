using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Harvest
{
    class Program
    {
        static void Main(string[] args)
        {

            //      От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.
            //      От 1 кв.м лозе се изкарват Y килограма грозде.
            //      За 1 литър вино са нужни 2,5 кг. грозде. Желаното количество вино за продан е Z литра.


            var sqMeters = int.Parse(Console.ReadLine());
            var grapePerMeter = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = sqMeters * grapePerMeter;
            var madedWine = ( 40.0/100.0 * totalGrape) / 2.5;
            var leftedWine = madedWine - neededWine;

            if (madedWine >= neededWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(madedWine)} liters.");
                var winePerWorker = leftedWine / workers;
                Console.WriteLine($"{Math.Ceiling(leftedWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Math.Abs(leftedWine))} liters wine needed.");
            }
        }
    }
}
