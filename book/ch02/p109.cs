using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p109
    {
        static void Main61(string[] args)
        {
            //int자료형 숫자를 생성합니다.
            int intnumber = 2147483647;

            //int자료형을 long자료형으로 자동변환 합니다.
            long IntToLong = intnumber;
            Console.WriteLine(IntToLong);

            //int자료형을 double자료형으로 자동변환 합니다.
            double IntToDouble = intnumber;
            Console.WriteLine(IntToDouble);

        }
    }
}
