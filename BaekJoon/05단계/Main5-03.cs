using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._05단계
{
    internal class Main5_03
    {
        public static bool Hansu(int x)
        {
            bool tf = false;
            string sx = x.ToString();



            if (sx.Length <= 2)
            {
                tf = true;
            }
            else if (sx.Length <= 3)
            {
                int a = int.Parse(sx[0].ToString());
                int b = int.Parse(sx[1].ToString());
                int c = int.Parse(sx[2].ToString());
                tf = (a-b == b-c);
            }
            else
                tf = false;


            return tf;
        }
        static void Main3(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 0;

            for (int i = 1; i <= n; i++)
            {
                if (Hansu(i))
                {
                    output++;
                }
            }
            Console.WriteLine(output);
        }
    }
}
