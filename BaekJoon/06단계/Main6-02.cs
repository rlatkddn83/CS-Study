using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_02
    {
        static void Main2(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(s[i].ToString()); 
            }
            Console.WriteLine(sum);
        }
    }
}
