using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int i = 0; i < r; i++)
                {
                    Console.Write(i == 0 ? "$" : " $");
                }
                Console.WriteLine();
            }

        }
    }
}
