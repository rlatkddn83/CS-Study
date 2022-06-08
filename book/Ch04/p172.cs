using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class p172
    {
        static void Main17(string[] args)
        {
            //17
            //변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            //반복을 수행합니다.
            foreach (string item in array)
            {
                //출력합니다.
                Console.WriteLine(item);
            }

            //18
            //반복을 수행합니다.
            foreach (var item in array)
            {
                //출력합니다.
                Console.WriteLine(item);
            }

        }
    }
}
