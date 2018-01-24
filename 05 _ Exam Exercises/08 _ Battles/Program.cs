using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pl1Pokemons = int.Parse(Console.ReadLine());
            int pl2Pokemons = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i1 = 1; i1 <= pl1Pokemons; i1++)
            {
                for (int i2 = 1; i2 <= pl2Pokemons; i2++)
                {
                    count++;
                    Console.Write($"({i1} <-> {i2}) ");
                    if (count == maxBattles)
                    {
                        return;
                    }
                }
              
            }


        }
    }
}
