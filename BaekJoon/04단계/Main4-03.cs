using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_03
    {
        static void Main3(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            string mt = (n1 * n2 * n3) + "";
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < mt.Length; i++)
            {
                count[int.Parse(mt[i].ToString())]++;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
    }
}
