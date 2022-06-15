using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_07
    {
        static void Main7(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] pers = new double[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();
                int[] ps = new int[ss.Length];
                int sum = 0;
                for (int j = 0; j < ss.Length; j++)
                {
                    ps[j] = int.Parse(ss[j]);
                    if (j > 0)
                    {
                        sum += ps[j];
                    }
                }
                double avg = sum / ps[0];
                double up = 0;
                for (int k = 1; k <= ps[0]; k++)
                {
                    if (ps[k] > avg)
                    {
                        up++;
                    }
                }
                double per = up / ps[0];
                pers[i] = per;
            }
            for (int l = 0; l < n; l++)
            {
                Console.WriteLine("{0}%", string.Format("{0:0.##0}", pers[l] * 100));
            }
        }
    }
}
