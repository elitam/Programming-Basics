using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double bitCoinInDollars = double.Parse(Console.ReadLine());
            int satoshi = int.Parse(Console.ReadLine());

            var totalBitCoins = dollars / bitCoinInDollars;
            var taxBitCoin = totalBitCoins * (satoshi * 1024) / 100000000;
            var taxInDollars = Math.Round(taxBitCoin * bitCoinInDollars, 2);
            var bitCoins = Math.Round(totalBitCoins - taxBitCoin, 5);
            var myMoney = bitCoins * 0.1;
            var hisBitCoin = bitCoins - myMoney;

            Console.WriteLine($"Total bitcoin after expenses: {hisBitCoin} BTC");
            Console.WriteLine($"Tax payed: {taxInDollars} USD");
            Console.WriteLine($"Programmer`s payment: {myMoney} BTC");
        }
    }
}
