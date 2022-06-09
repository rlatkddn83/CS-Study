using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 김상우
 * 내용 : 증가, 감소 연산자 연습문제
 */
namespace TEST._1
{
    internal class _1_04
    {
        static void Main4(string[] args)
        {
            int num = 1;
            int result;

            result = num++;
            Console.WriteLine("result : " + result);
            result = ++num;
            Console.WriteLine("result : " + result);
            result = num--;
            Console.WriteLine("result : " + result);
            result = --num;
            Console.WriteLine("result : " + result);
        }
    }
}
