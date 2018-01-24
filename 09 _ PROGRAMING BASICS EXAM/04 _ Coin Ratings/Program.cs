using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Coin_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            //   DOGE 1 = EUR 0.07
            //   IOTA 1 = EUR 1.44
            //   NEO 1 = EUR 28.50
            //   ESTD 1 = EUR 25.0
            int n = int.Parse(Console.ReadLine());

            var doge = 0.07;
            var iota = 1.44;
            var neo = 28.50;
            var estd = 25.0;
            var sum = 0.0;

            var dogeCounter = 0;
            var iotaCounter = 0;
            var neoCounter = 0;
            var estdCounter = 0;

            for (int i = 0; i < n; i++)
            {
                var currency = Console.ReadLine();
                double coins = double.Parse(Console.ReadLine());

                if (currency == "DOGE")
                {
                    sum += coins * doge;
                    var coinsD = coins / doge;
                    dogeCounter++;
                }
                else if (currency == "IOTA")
                {
                    sum += coins * iota;
                    var coinsI = coins / iota;
                    iotaCounter++;
                }
                else if (currency == "NEO")
                {
                    sum += coins * neo;
                    var coinsN = coins / neo;
                    neoCounter++;
                }
                else if (currency == "ESTD")
                {
                    sum += coins * estd;
                    var coinsE = coins / estd;
                    estdCounter++;
                }

            }

            var dogeEuro = dogeCounter * 0.7;
            var iotaEuro = iotaCounter * 1.44;
            var neoEuro = neoCounter * 28.50;
            var estdEuro =estdCounter * 25.0;
            
            var dogePercent = (dogeEuro / sum) * 100;
            var iotaPercent = (iotaEuro / sum) * 100;
            var neoPercent = (neoEuro / sum) * 100;
            var estdPercent = (estdEuro / sum) * 100;

            Console.WriteLine($"Total votes = {n}, Money in market = {sum} EUR");
            Console.WriteLine($"DOGE's contribution: {dogePercent:f2}%; People who use DOGE: {dogeCounter}");
            Console.WriteLine($"IOTA's contribution: {iotaPercent:f2}%; People who use IOTA: {iotaCounter}");
            Console.WriteLine($"NEO's contribution: {neoPercent:f2}%; People who use NEO: {neoCounter}");
            Console.WriteLine($"ESTD's contribution: {estdPercent:f2}%; People who use ESTD: {estdCounter}");
        }
    }
}
