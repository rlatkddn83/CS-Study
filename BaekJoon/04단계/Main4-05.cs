using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_05
    {
        static void Main5(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] point = Console.ReadLine().Split();
            double max = 0;
            double sum = 0;

            for (int i = 0; i < point.Length; i++)
            {
                int x = int.Parse(point[i]);
                if (max < x)
                {
                    max = x;
                }
                sum += x;
            }
            double y = (sum * 100) / (max * point.Length);
            Console.WriteLine(y);
        }
    }
}
