using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupes = int.Parse(Console.ReadLine());
            var allPeople = 0.0;
            var carPeople = 0.0;
            var minibusPeople = 0.0;
            var smallBusPeople = 0.0;
            var bigBusPeople = 0.0;
            var trainPeople = 0.0;

            for (int i = 0; i < groupes; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                allPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    carPeople += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    minibusPeople += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    smallBusPeople += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    bigBusPeople += peopleInGroup;
                }
                else
                {
                    trainPeople += peopleInGroup;
                }
            }

            Console.WriteLine("{0:f2}%", carPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", minibusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", smallBusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", bigBusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", trainPeople / allPeople * 100);
        }
    }
}
