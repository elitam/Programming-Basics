using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidht = int.Parse(Console.ReadLine());
            int cakeHight = int.Parse(Console.ReadLine());
            var pieces = cakeHight * cakeWidht;
            var leftPieces = pieces;

            for (int i = 0; i < pieces; i++)
            {
                var takenPiece = Console.ReadLine();
                if (takenPiece == "STOP")
                {
                    Console.WriteLine($"{leftPieces} pieces are left.");
                        return;
                }
                else
                {
                     leftPieces -= int.Parse(takenPiece);
                }
                if (leftPieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(leftPieces)} pieces more.");
                        return;
                }
            }
        }
    }
}
