using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_02
    {
        static void Main2(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = 1;
            int z;
            int i = 0;
            while (true)
            {
                y += 6 * i;
                if (x <= y)
                {
                    z = i + 1;
                    break;
                }
                i++;
            }
            Console.WriteLine(z);
        }
    }
}
