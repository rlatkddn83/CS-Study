using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_02
    {
        public static bool Sosu(int x)
        {
            int y = 2;
            while (y < x)
            {
                if (x % y == 0 && x != y)
                {
                    return false;
                }
                y++;
            }
            return true;
        }
        static void Main2(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = m; i <= n; i++)
            {
                if(Sosu(i) && i != 1)
                    list.Add(i);
            }
            if (list.Count == 0) { Console.WriteLine(-1); }
            else
            {
                int sum = 0;
                int min = list[0];
                foreach (int x in list)
                {
                    sum += x;
                }
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
