using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int lessons = int.Parse(Console.ReadLine());
            var budjet = double.Parse(Console.ReadLine());

            var budjetPerLesson = budjet / lessons;
            var jelev = 0.0;
            var royal = 0.0;
            var roli = 0.0;
            var trofon = 0.0;
            var sino = 0.0;
            var guests = 0.0;

            for (int i = 0; i < lessons; i++)
            {
                var trainer = Console.ReadLine();
                if (trainer == "Jelev")
                {
                    jelev += budjetPerLesson;
                }
                else if (trainer == "RoYaL")
                {
                    royal += budjetPerLesson;
                }
                else if (trainer == "Roli")
                {
                    roli += budjetPerLesson;
                }
                else if (trainer == "Trofon")
                {
                    trofon += budjetPerLesson;
                }
                else if (trainer == "Sino")
                {
                    sino += budjetPerLesson;
                }
                else
                {
                    guests += budjetPerLesson;
                }
            }

            Console.WriteLine($"Jelev salary: {jelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {royal:f2} lv");
            Console.WriteLine($"Roli salary: {roli:f2} lv");
            Console.WriteLine($"Trofon salary: {trofon:f2} lv");
            Console.WriteLine($"Sino salary: {sino:f2} lv");
            Console.WriteLine($"Others salary: {guests:f2} lv");

        }
    }
}
