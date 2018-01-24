using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ....x....       n = 3
            //  .../x\...
            //  ...x|x...
            //  .xxx|xxx.
            //  xxxx|xxxx
            //  .xxx|xxx.
            //  .../x\...
            //  ...\x/...
            //  .xxx|xxx.
            //  xxxx|xxxx
            //  .xxx|xxx.
            //  ...x|x...
            //  ...\x/...
            //  ....x....

            int n = int.Parse(Console.ReadLine());
            var width = n * 3;
            var dots = (width - 1) / 2;
            var hiks = n - 1;

            Console.WriteLine("{0}x{0}", new string('.', dots));
            dots--;
            Console.WriteLine("{0}/x\\{0}", new string('.', dots));
            Console.WriteLine("{0}x|x{0}", new string('.', dots));

            for (int i = 0; i < n; i++)
            {
                if (i <= n / 2)
                {
                    hiks++;
                }
                else
                {
                    hiks--;
                }
                dots = (width - 1 - 2 * hiks) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', hiks));
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            hiks--;

            for (int i = 0; i < n; i++)
            {
                if (i <= n / 2)
                {
                    hiks++;
                }
                else
                {
                    hiks--;
                }
                dots = (width - 1 - 2 * hiks) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', hiks));
            }

            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));

        }
    }
}
