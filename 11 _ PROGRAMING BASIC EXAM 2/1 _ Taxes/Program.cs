using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var beginCapital = double.Parse(Console.ReadLine());
            var endCapital = double.Parse(Console.ReadLine());
            var taxePerc = double.Parse(Console.ReadLine());

            var profit = endCapital - beginCapital;
            var reInvest = profit * 0.4;
            var currencyInvest = reInvest * 0.5;
            var moneyForTaxes = profit - reInvest - currencyInvest;
            var taxe = moneyForTaxes * taxePerc / 100;
            var finalProfit = beginCapital + reInvest - taxe;

            Console.WriteLine($"Capital at the end of the year: EUR {finalProfit:f2}");
            Console.WriteLine($"Taxes Paid: EUR {taxe:f2}");
        }
    }
}
