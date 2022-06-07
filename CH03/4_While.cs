using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 :  2022/06/07
 * 이름 : 김상우
 * 내용 : 반복문 wwhile 실습하기 교재 p162
 */
namespace CH03
{
    internal class _4_While
    {
        static void Main4(string[] args)
        {
            // 1부터 10까지 합
            int k  = 1;
            int sum = 0;
            while (k <= 10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지 합 : "+sum);

            // do ~ while : 최초 1번은 무조건 반복 실행하는 반복문
            int sum2 = 0;
            int i = 1;

            do
            {
                if (i%2 == 0)
                {
                    sum2 += i;
                }
                i++;
            } 
            while (i<=10);
            Console.WriteLine("1부터 10까지 짝수합 : "+sum2);

            // break
            int num = 1;
            while (true)
            {
                if (num%5==0 && num%7==0)
                {
                    break;
                }
                num++;
            }
            Console.WriteLine("5와 7의 최소공배수 : "+num);

            // continue
            int sum3 = 0;
            int j = 0;

            while (j<=10)
            {
                j++; 
                if (j%2==1)
                { continue; }
                sum3 += j;
            }
            Console.WriteLine("1부터 10까지 짝수합 : " + sum3);

        }
    }
}
