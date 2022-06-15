using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_03
    {
        static void Main3(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            int p;
            int c;
            bool tf = false;
            int i = 1;
            int z;
            while (true)
            {
                y += i;
                if (x <= y) 
                {
                    z = y - x;
                    break;
                }
                tf = !tf;
                i++;
            }
            if (tf)
            {
                c = i - z;
                p = z + 1;
            }
            else
            {
                p = i - z;
                c = z + 1;
            }
            Console.WriteLine(c+"/"+p);
        }
    }
}
