using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p108
    {
        static void Main59(string[] args)
        {
            //59
            //long자료형을 int자료형으로 변환합니다.
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            //60
            //long자료형을 int자료형으로 변환합니다.
            longNumber = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber;
            Console.WriteLine(longToInt);

            //double자료형을 int자료형으로 변환합니다.
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
    }
}
