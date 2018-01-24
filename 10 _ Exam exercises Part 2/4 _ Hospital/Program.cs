using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var doctors = 7;
            var untreatedPatients = 0;
            var allPatients = 0;
            var treatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                int patientsPerDay = int.Parse(Console.ReadLine());
                allPatients += patientsPerDay;
                untreatedPatients += patientsPerDay > doctors ? patientsPerDay - doctors : 0;
                treatedPatients += patientsPerDay > doctors ? doctors : patientsPerDay;
            }
            Console.WriteLine($"Treated patients: { treatedPatients}.");
            Console.WriteLine($"Untreated patients: { untreatedPatients}.");
             
        }

    }
}
