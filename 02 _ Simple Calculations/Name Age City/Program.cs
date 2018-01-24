using System;

namespace name_age_town
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.Write("First name: ");
            var firstname = Console.ReadLine();

            Console.Write("Last name: ");
            var lastname = Console.ReadLine();

            Console.Write("Age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("City: ");
            var town = Console.ReadLine();
           
            //print
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, age, town);

        }
    }
}
