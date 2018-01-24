using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var liters = 0.0;
            var degrees = 0.0;
            var literDegrees = 0.0;

            for (int i = 0; i < days; i++)
            {
                var litersDay = double.Parse(Console.ReadLine());
                var degreesDay = double.Parse(Console.ReadLine());
                liters += litersDay;
                degrees += degreesDay;
                literDegrees += litersDay * degreesDay;
            }
            var averageDegrees = literDegrees / liters;
            Console.WriteLine($"Liter: {liters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
