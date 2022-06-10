using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_14
    {
        static void Main14(string[] args)
        {
            string inp = Console.ReadLine();
            int x;
            int y;
            string cal;
            string cmp1 = inp;
            string cmp2 = "";
            int cy = 0;

            do
            {
                if (int.Parse(cmp1) < 10)
                {
                    cmp2 = "0" + cmp1;
                }
                else
                {
                    cmp2 = cmp1;
                }
                x = int.Parse(cmp2[0] + "");
                y = int.Parse(cmp2[1] + "");
                cal = (x + y).ToString();
                cmp1 = cmp2[cmp2.Length - 1].ToString() + cal[cal.Length - 1].ToString();
                x = int.Parse(cmp1);
                cmp1 = x.ToString();
                cy++;
            } while (inp != cmp1);
                Console.WriteLine(cy);
         }
    }
}
