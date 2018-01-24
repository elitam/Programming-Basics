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
            // Ако продукта е „cola“  или „wine“ – пращаме в група „Beverages“
            // Ако продукта е „baklavichka“, или  „cupcake“ -пращаме в група „Sweets“.
            // Ако продукта е  „flower“, „chocolates“ или „book“ -пращаме в група „Presents“
            // Всичко, което не е едно от горепосочените отива в група „other products.“
            int purchases = int.Parse(Console.ReadLine());
            var countBeverages = 0.0;
            var countSweets = 0.0;
            var countPresents = 0.0;
            var countOther = 0.0;

            var spendMoney = 0.0;
            for (int i = 0; i < purchases; i++)
            {
                var product = Console.ReadLine();
                var productPrice = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());
                spendMoney += productPrice * quantity;

                if (product == "cola" || product == "wine")
                {
                    countBeverages += productPrice * quantity;
                }
                else if (product == "baklavichka" || product == "cupcake")
                {
                    countSweets += quantity * productPrice;
                }
                else if (product == "flower" || product == "book" || product == "chocolates")
                {
                    countPresents += quantity * productPrice;
                }
                else
                {
                    countOther += quantity * productPrice;
                }
            }
            var beveragesPerc = countBeverages / spendMoney * 100;
            var sweetsPerc = countSweets / spendMoney * 100;
            var presentsPerc = countPresents / spendMoney * 100;
            var otherPerc = countOther / spendMoney * 100;

            Console.WriteLine($"Total money spent: {spendMoney:f2}");
            Console.WriteLine($"Money spent on: Sweets - {sweetsPerc:f2}%; " +
                             $"Beverages - {beveragesPerc:f2}%; " +
                             $"Presents - {presentsPerc:f2}%;");
            Console.WriteLine($"Money spent on other products: {countOther:f2} or {otherPerc:f2}%");
        }
    }
}
