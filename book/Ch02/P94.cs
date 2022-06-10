using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P94
    {
        static void Main42(string[] args)
        {
            //후위
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            //전위
            number = 10;
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
        }
    }
}
