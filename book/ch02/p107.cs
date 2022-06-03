using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p107
    {
        static void Main57(string[] args)
        {
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;
        }
        static void Main58(string[] args)
        {
            //long자료형을 int자료형으로 변환합니다.
            long longnumber = 2147483647L + 2147483647L;
            int intnumber = (int) longnumber;
            Console.WriteLine(intnumber);
        }
    }
}
