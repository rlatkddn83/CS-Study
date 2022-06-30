
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._9
{
    internal class _9_07
    {
        static void Main7(string[] args)
        {
            DrawPramid(3);
            DrawPramid(5);
            DrawPramid(7);
        }

        public static void DrawPramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");

                for (int k = 1; k < 2 * i; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
