using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPerKg = double.Parse(Console.ReadLine());
            double cacaPerKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            var palamudPerKg = skumriaPerKg + skumriaPerKg * 0.6;
            var safridPerKg = cacaPerKg + cacaPerKg * 0.8;
            var midiPerKg = 7.5;

            var palamud = palamudKg * palamudPerKg;
            var safrid = safridKg * safridPerKg;
            var midi = midiKg * midiPerKg;

            Console.WriteLine("{0:f2}", palamud + safrid + midi);
        }
    }
}
