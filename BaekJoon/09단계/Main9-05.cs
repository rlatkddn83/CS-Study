using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    class Hanoi
    {
        public int k = 0;
        public StringBuilder sb = new StringBuilder();

        public void Move(int x, int a, int b, int c)
        {
            if (x == 1)
            {
                this.sb.AppendLine(a + " " + c);
                this.k++;
            }
            else
            {
                Move(x - 1, a, c, b);
                this.sb.AppendLine(a + " " + c);
                this.k++;
                Move(x - 1, b, a, c);
            }
        }
    }
    internal class Main9_05
    {

        static void Main5(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Hanoi h = new Hanoi();
            h.Move(n, 1, 2, 3);
            Console.WriteLine(h.k);
            Console.WriteLine(h.sb.ToString());
        }
    }
}
