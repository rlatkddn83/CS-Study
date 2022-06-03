using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p96
    {
        static void Main44(string[] args)
        {
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
        }
        static void Main45(string[] args)
        {
            int number = 10;
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
