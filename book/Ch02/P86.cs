using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P86
    {
        static void Main32(string[] args)
        {
            //32
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            //33
            char a = 'a';
            char b = 'b';

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
        }
    }
}
