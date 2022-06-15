using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_10
    {
        static void Main10(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            int[] abc = new int[26];
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                abc = new int[26];
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (abc[s[i][j] - 97] == 0)
                        abc[s[i][j] - 97] = 1;
                    else if (abc[s[i][j] - 97] == 1 && s[i][j] != s[i][j - 1])
                        break;
                    if (j == s[i].Length - 1)
                    {
                        x++;
                    }
                }
            }
            Console.WriteLine(x);
        }
    }
}
