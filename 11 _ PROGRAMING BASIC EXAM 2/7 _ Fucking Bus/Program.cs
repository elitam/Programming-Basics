using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Fucking_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Distance in km: ");
            var km = double.Parse(Console.ReadLine());
            Console.Write("Speed in km/h: ");
            var speed = double.Parse(Console.ReadLine());

            var people = 0;

            for (int i = 0; i < 9; i++)
            {
                people = int.Parse(Console.ReadLine());
            }
        }
    }
}
