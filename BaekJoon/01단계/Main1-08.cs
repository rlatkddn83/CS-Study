using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_08
    {
        static void Main8(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);

            Console.WriteLine(A / B);
        }
    }
}
