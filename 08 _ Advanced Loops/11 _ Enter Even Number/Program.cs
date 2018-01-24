using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter even number : ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                }
                else
                {
                    Console.WriteLine("The number is not even");

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
                throw;
            }
        }
    }
}
