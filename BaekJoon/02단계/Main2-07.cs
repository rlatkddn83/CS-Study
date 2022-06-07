using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_07
    {
        static void Main7(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int Pd = 0;
            int Pm = 1;
            int max = 0;
            int Prize = 0;

            if (A == B || A == C)
            { 
                Pd = A; 
                if (B == C) { Pm = 3; }
                else { Pm = 2; }
            }
            else if (B == C)
            { 
                Pd = B; 
                Pm = 2;
            }
            else
            {
                if (A > B)
                {
                    if(A > C)
                    { max = A; }
                    else{ max = C; }
                }
                else
                {
                    if(B > C)
                    { max = B; }
                    else { max = C; }
                }
            }

            switch (Pm)
            {
                case 3:
                    Prize = 10000 + (Pd * 1000);
                    break;
                case 2:
                    Prize = 1000 + (Pd * 100);
                    break;
                default:
                    Prize = max * 100;
                    break;
            }

            Console.WriteLine(Prize);
        }
    }
}
