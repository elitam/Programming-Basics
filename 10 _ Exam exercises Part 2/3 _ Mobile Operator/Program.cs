using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var term = Console.ReadLine();
            var contractTipe = Console.ReadLine();
            var internet = Console.ReadLine();
            var monts = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (contractTipe == "Small")
            {
                price = term == "one" ? 9.98 : 8.58;
            }
            else if (contractTipe == "Middle")
            {
                price = term == "one" ? 18.99 : 17.09;
            }
            else if (contractTipe == "Large")
            {
                price = term == "one" ? 25.98 : 23.59;
            }
            else if (contractTipe == "ExtraLarge")
            {
                price = term == "one" ? 35.99 : 31.79;
            }

            if (internet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }
            price -= term == "two" ? price * 0.0375 : 0;
            var totalPrice = price * monts;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
