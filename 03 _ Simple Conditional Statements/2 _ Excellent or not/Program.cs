using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var grade = double.Parse(Console.ReadLine());

            // check if excellent 
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!"); 
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }

        }
    }
}
