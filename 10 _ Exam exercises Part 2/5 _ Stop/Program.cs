using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            //      ...._______....  n = 3              
            //      ...//_____\\...                     
            //      ..//_______\\..                     
            //      .//_________\\.                     
            //      //___STOP!___\\
            //      \\___________//
            //      .\\_________//.
            //      ..\\_______//..

            int n = int.Parse(Console.ReadLine());
            var width = n * 4 + 3;

            var dots = n + 1;
            var dotsStr = new string('.', dots);

            var downL = width - 2 * dots;
            var downLStr = new string('_', downL);
            var backSlash = new string('\\', 1);

            Console.WriteLine($"{dotsStr}{downLStr}{dotsStr}"); // first line

            var downLine = n * 2 - 1;
            var downLineStr = new string('_', downLine);
            for (int i = 0; i < n; i++)
            {
                dots--;
                dotsStr = new string('.', dots);

                Console.WriteLine($"{dotsStr}//{downLineStr}\\{backSlash}{dotsStr}");
                downLine += 2;
                downLineStr = new string('_', downLine);

            } // upper part

            downLine = (width - 9) / 2;
            downLineStr = new string('_', downLine);
            Console.WriteLine($"//{downLineStr}STOP!{downLineStr}\\{backSlash}"); // STOP

            downLine = width - 4;
            downLineStr = new string('_', downLine);

            for (int i = 0; i < n; i++)
            {
                dots = i;
                dotsStr = new string('.', dots);
                Console.WriteLine($"{dotsStr}\\{backSlash}{downLineStr}//{dotsStr}");
                downLine -= 2;
                downLineStr = new string('_', downLine);

            } // lower part

        }
    }
}
