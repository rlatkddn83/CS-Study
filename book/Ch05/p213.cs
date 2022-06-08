using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class p213
    {
        static void Main6(string[] args)
        {
            //6
            //변수를 선언합니다.
            List<int> list = new List<int>();

            //리스트에 요소를 추가합니다.
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            //반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            //7
            //변수를 선언합니다.
            List<int> list2 = new List<int>() { 52, 273, 32, 64 };

            //반복을 수행합니다.
            foreach (var item in list2)
            {
                Console.WriteLine("Count: "+list.Count+"\titem: "+item);
            }

        }
    }
}
