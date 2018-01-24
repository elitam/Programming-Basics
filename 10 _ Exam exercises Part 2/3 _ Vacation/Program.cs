using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int sleeps = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var allPassengers = adults + students;

            var hotel = sleeps * 82.99;

            var trainAdult = 24.99;
            var trainStudent = 14.99;
            var busAdult = 32.5;
            var busStudent = 28.5;
            var airplaneAdult = 70.00;
            var airplaneStudent = 50.00;
            var boatAdult = 42.99;
            var boatStudent = 39.99;

            var sum = 0.0;

            if (transport == "train")
            {
                if (allPassengers > 50)
                {
                    trainAdult *= adults * 0.5;
                    trainStudent *= students * 0.5;
                    sum = 2*(trainAdult + trainStudent);
                }
                else
                {
                    trainAdult *= adults;
                    trainStudent *= students;
                    sum = 2 * (trainAdult + trainStudent);
                }

            }
            else if (transport == "bus")
            {
                busAdult *= adults;
                busStudent *= students;
                sum = 2 * (busAdult + busStudent);
            }
            else if (transport == "airplane")
            {
                airplaneAdult *= adults;
                airplaneStudent *= students;
                sum = 2 * (airplaneAdult + airplaneStudent);
            }
            else if (transport == "boat")
            {
                boatAdult *= adults;
                boatStudent *= students;
                sum = 2 * (boatStudent + boatAdult);
            }

            var totalPrice = hotel + sum;
            var comission = 0.1 * totalPrice;
            var finalPrice = totalPrice + comission;

            Console.WriteLine("{0:f2}", finalPrice);

        }
    }
}
