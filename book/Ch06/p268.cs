﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{
    internal class p268
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }
        static void Main3(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();
        }
    }
}
