using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlPokemons = int.Parse(Console.ReadLine());
            int secondPlPokemons = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i1 = 1; i1 <= firstPlPokemons; i1++)
            {
                for (int i2 = 1; i2 <= secondPlPokemons; i2++)
                {
                    counter++;
                    if (counter > battles)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write($"({i1} <-> {i2}) ");
                    }
                }
            }
        }
    }
}
