using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            var allEnergy = 100.00 * days * dancers;
            var energyPercent = 0.00;
            var givenEnergy = 0.00;
            var leftEnergy = 0.00;

            for (int i = 1; i <= days; i++)
            {
                int hoursPerDay = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && hoursPerDay % 2 == 0)
                {
                    energyPercent += 68 * dancers;
                }
                else if (i % 2 != 0 && hoursPerDay % 2 == 0)
                {
                    energyPercent += 49 * dancers;
                }
                else if (i % 2 == 0 && hoursPerDay % 2 != 0)
                {
                    energyPercent += 65 * dancers;
                }
                else if (i % 2 != 0 && hoursPerDay % 2 != 0)
                {
                    energyPercent += 30 * dancers;
                }
            }
            leftEnergy = allEnergy - energyPercent;
            var averageEnergy = leftEnergy / days / dancers;

            if (averageEnergy >= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {averageEnergy:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {averageEnergy:f2}");
            }


        }
    }
}
