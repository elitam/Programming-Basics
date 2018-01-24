using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Pasword_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPass = Console.ReadLine();
            var rightPass = "s3cr3t!P@ssw0rd";

            if (inputPass == rightPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
