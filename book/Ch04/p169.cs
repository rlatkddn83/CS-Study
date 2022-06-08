using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class p169
    {
        static void Main15(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;

            //반복을 수행합니다: 10,000,000Tick = 1초
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count+"만큼 반복했습니다.");//출력합니다.
        }
    }
}
