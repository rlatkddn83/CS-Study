﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class p159
    {
        static void Main4(string[] args)
        {
            //4
            // 배열을 생성합니다.
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 배열의 요소를 변경합니다.
            intArray[0] = 0;

            // 요소를 출력합니다.
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);

            //5
            // 배열의 길이를 출력합니다.
            Console.WriteLine(intArray.Length);
        }
    }
}
