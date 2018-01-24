using System;


namespace Rectangle_Square_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.Write("a= ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            var b = int.Parse(Console.ReadLine());

            var area = a * b;

            //calculating
            Console.Write("Rectangle area is: ");
            Console.WriteLine(area);
        }
    }
}
