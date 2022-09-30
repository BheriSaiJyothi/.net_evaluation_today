using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class mulfact
    {
        public static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());
            int h = 1;
            int i;
            Console.WriteLine(" the multiplication table of" + y + "is :");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(y + "*" + i + "=" + (y * i));
            }
            Console.WriteLine(" the factorial of a number " + y + "is:");
            for (i = 1; i <= y; i++)
            {
                h = h * i;
            }
            Console.WriteLine(h);
        }
    }
}
