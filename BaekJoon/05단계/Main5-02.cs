using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._05단계
{
    internal class Main5_02
    {
        public static int Cr(int x)
        {
            string sx = x.ToString();
            int y = x;

            foreach (char c in sx)
            {
                y += int.Parse(c.ToString());
            }

            return y;
        }

        static void Main2(string[] args)
        {
            int z = 1;
            int[] cr = new int[10000];

            for (int i = 1; i <= cr.Length-1; i++)
            {
                z = i;
                while (true)
                {
                    if (z >= 10000)
                        break;
                    else if (z == cr[z])
                        break;
                    if (z !=  i)
                        cr[z] = z;
                    z = Cr(z);
                }
            }
            for (int i = 1; i <= cr.Length-1; i++)
            {
                if (i == cr[i])
                    continue;
                else
                    Console.WriteLine(i);
            }
        }
    }
}
