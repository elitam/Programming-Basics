using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //      •	ако числото се дели на 5 без остатък, извадете от него първата му цифра, 
            //      •	ако числото се дели на 3 без остатък, извадете от него втората му цифра, 
            //      •	ако не е нито едно от горните – прибавете към него третата му цифра,

            int n = int.Parse(Console.ReadLine());
            var d1 = n / 100;
            var d2 = (n / 10) % 10;
            var d3 = n % 10;

            var rows = d1 + d2;
            var cols = d1 + d3;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (n % 5 == 0)
                    {
                        n -= d1;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= d2;
                    }
                    else
                    {
                        n += d3;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
