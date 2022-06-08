using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class p179
    {
        static void Main24(string[] args)
        {
            //24
            for (int i = 0; i < 10; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //25
            for (int i = 0; i < 10; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
