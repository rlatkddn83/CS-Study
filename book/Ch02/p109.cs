using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p109
    {
        static void Main61(string[] args)
        {
            //int자료형의 숫자를 생성합니다.
            int intNumber = 2147483647;

            //int자료형을 long자료형으로 자동 변환합니다.
            long intTOLong = intNumber;
            Console.WriteLine(intTOLong);

            //int자료형을 double자료형으로 자동변환합니다.
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
