﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class p214
    {
        static void Main8(string[] args)
        {
            //변수를 선언합니다.
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            //제거를 수행합니다.
            list.Remove(52);

            //반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }
        }
    }
}
