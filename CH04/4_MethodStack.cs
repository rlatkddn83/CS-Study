using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 :  2022/06/07
 * 이름 : 김상우
 * 내용 : 메서드 출력전용 매개변수
 */
namespace CH04
{
    internal class _4_MethodStack
    {
        static void Main4(string[] args)
        {
            int result = 0;
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);

            Console.WriteLine("result : "+result);
        }

        public static int Sum(int start, int end)
        {
            int total = 0;
            for (int k = start; k <= end; k++)
            {
                total += k;
            }

            return total;
        }
    }
}
