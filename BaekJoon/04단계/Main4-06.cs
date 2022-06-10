using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_06
    {
        static void Main6(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ox = new string[n];
            
            int[] p = new int[n];
            for (int i = 0; i < n; i++)
            {
                ox[i] = Console.ReadLine();
                int x = 0;
                int y = 0;
                for (int j = 0; j < ox[i].Length; j++)
                {
                    if (ox[i][j] == 'O')
                    {
                        x++;
                        y += x;
                    }
                    else
                    {
                        x = 0;
                    }
                }
                p[i] = y;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}
