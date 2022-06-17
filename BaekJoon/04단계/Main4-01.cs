using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_01
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split();

            for (int i = 1; i < n; i++)
            {
                if (int.Parse(data[i-1]) > int.Parse(data[i]))
                {
                    string temp = data[i-1];
                    data[i-1] = data[i];
                    data[i] = temp;
                    if (int.Parse(data[i-1]) < int.Parse(data[0]) && i>1)
                    {
                        data[0] = data[i-1];
                    }
                }
            }
            Console.WriteLine("{0} {1}", data[0], data[n - 1]);
        }
    }
}
