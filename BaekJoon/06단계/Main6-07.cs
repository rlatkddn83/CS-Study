using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_07
    {
        public static int Rev(int x)
        {
            string sx = x.ToString();
            int y = int.Parse(sx[2].ToString() + sx[1].ToString() + sx[0].ToString());
            return y;
        }
        static void Main7(string[] args)
        {
            string[] sn = Console.ReadLine().Split();
            int nr1 = Rev(int.Parse(sn[0]));
            int nr2 = Rev(int.Parse(sn[1]));

            if (nr1 > nr2)
                Console.WriteLine(nr1);
            else
                Console.WriteLine(nr2);
        }
    }
}
