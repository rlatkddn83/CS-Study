using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P96
    {
        static void Main44(string[] args)
        {
            //44
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);

            //45
            number = 10;
            Console.WriteLine(number);
            number++;
            number++;
            Console.WriteLine(number);
            Console.WriteLine(number);
            number--;
            number--;
            Console.WriteLine(number);
        }
    }
}
