using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_05B
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 1;
            string output = "";

            while (i < input + 1)
            {
                if (j > 1000)
                {
                    Console.WriteLine(output);
                    output = "";
                    j = 1;
                }
                output += i + "\r\n";

                i++;
                j++;
            }
            Console.WriteLine(output);
        }
    }
}