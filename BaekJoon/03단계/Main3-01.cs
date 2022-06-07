using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_01
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",input, i,input*i);
            }
        }
    }
}
