using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._01단계
{
    internal class Main1_13
    {
        static void Main13(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int numA = int.Parse(input1);
            int numB = int.Parse(input2);
            int numB1 = numB / 100;
            int numB2 = (numB - (numB1 * 100)) / 10;
            int numB3 = (numB - (numB1 * 100)) % 10;

            Console.WriteLine(numA * numB3);
            Console.WriteLine(numA * numB2);
            Console.WriteLine(numA * numB1);
            Console.WriteLine(numA * numB);

        }
    }
}
