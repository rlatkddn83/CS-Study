using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_04
    {
        static void Main4(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                if (y > 0)
                { Console.WriteLine(1); }
                else
                { Console.WriteLine(4); }
            }
            else
            {
                if (y > 0)
                { Console.WriteLine(2); }
                else
                { Console.WriteLine(3); }

            }

        }
    }
}
