using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Young_Capitalist
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyFromParents = double.Parse(Console.ReadLine());
            int invitedKids = int.Parse(Console.ReadLine());
            var moneyPerKid = double.Parse(Console.ReadLine());
            var scooter = double.Parse(Console.ReadLine());

            var comingKids = Math.Ceiling(0.85 * invitedKids);
            var moneyFromKids = Math.Floor(0.8 * comingKids) * moneyPerKid;
            var totalMoney = moneyFromParents + moneyFromKids;
            var restaurant = 4.5 * comingKids;
            var finalMoney = totalMoney - restaurant;

            var scooterPrice = scooter + 0.05 * scooter;
            var moneyLeft = Math.Abs(finalMoney - scooterPrice);

            if (finalMoney >= scooterPrice)
            {
                Console.WriteLine($"Asparuh will be driving a fast 49cc Scooter soon.");
                Console.WriteLine($"Money left: {moneyLeft:f2} BGN");
            }
            else
            {
                Console.WriteLine($"If only Asparuh had {moneyLeft:f2} BGN more...");
                Console.WriteLine($"Guess he will be walking for now.");
            }
        }
    }
}
