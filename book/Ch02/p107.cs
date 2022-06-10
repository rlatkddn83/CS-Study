using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p107
    {
        static void Main57(string[] args)
        {
            //57
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            //58
            //long자료형을 int자료형으로 변환합니다.
            long longNumber = 2147483648L + 2147483648L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
