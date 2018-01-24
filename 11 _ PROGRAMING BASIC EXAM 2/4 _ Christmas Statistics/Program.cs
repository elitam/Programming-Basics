using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Christmas_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int purchases = int.Parse(Console.ReadLine());
            var beveragesMoney = 0.0;
            var sweetsMoney = 0.0;
            var presentsMoney = 0.0;
            var otherMoney = 0.0;

            var spendMoney = 0.0;
            for (int i = 0; i < purchases; i++)
            {
                var product = Console.ReadLine();
                var productPrice = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());
                spendMoney += productPrice * quantity;

                if (product == "cola" || product == "wine")
                {
                    beveragesMoney += productPrice * quantity;
                }
                else if (product == "baklavichka" || product == "cupcake")
                {
                    sweetsMoney += quantity * productPrice;
                }
                else if (product == "flower" || product == "book" || product == "chocolates")
                {
                    presentsMoney += quantity * productPrice;
                }
                else
                {
                    otherMoney += quantity * productPrice;
                }
            }
            var beveragesPerc = beveragesMoney / spendMoney * 100;
            var sweetsPerc = sweetsMoney / spendMoney * 100;
            var presentsPerc = presentsMoney / spendMoney * 100;
            var otherPerc = otherMoney / spendMoney * 100;

            Console.WriteLine($"Total money spent: {spendMoney:f2}");
            Console.WriteLine($"Money spent on: Sweets - {sweetsPerc:f2}%; " +
                             $"Beverages - {beveragesPerc:f2}%; " +
                             $"Presents - {presentsPerc:f2}%;");
            Console.WriteLine($"Money spent on other products: {otherMoney:f2} or {otherPerc:f2}%");
        }
    }
}
