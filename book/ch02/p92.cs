using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p92
    {
        static void Main39(string[] args)
        {
            string output = "Hello ";
            output += "World";
            output += "!";

            Console.WriteLine(output);
        }
        static void Main40(string[] args)
        {
            string output = "Hello ";
            output = output + "World";
            output = output + "!";

            Console.WriteLine(output);
        }
    }
}
