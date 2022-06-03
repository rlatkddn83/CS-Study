using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_13B
    {
        static void Main13B(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int numA = int.Parse(input1);
            int numB = int.Parse(input2);
            int numB1 = int.Parse(input2[0].ToString());
            int numB2 = int.Parse(input2[1].ToString());
            int numB3 = int.Parse(input2[2].ToString());

            Console.WriteLine(numA * numB3);
            Console.WriteLine(numA * numB2);
            Console.WriteLine(numA * numB1);
            Console.WriteLine(numA * numB);
        }
    }
}