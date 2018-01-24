using System;

namespace inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches=");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.WriteLine("Centimeters = " + cm);
            
        }
    }
}

