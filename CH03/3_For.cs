﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 :  2022/06/07
 * 이름 : 김상우
 * 내용 : 반복문 실습하기 교재 p157
 */
namespace CH03
{
    internal class _3_For
    {
        static void Main3(string[] args)
        {
            //for문
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}회 반복...", i);
            }
            //1부터 10까지 합
            int sum = 0;
            for (int k = 1; k <= 10; k++)
            {
                sum += k; // sum = sum + i
            }
            Console.WriteLine("1부터 10까지 합 : " + sum);

            //1부터 10까지 짝수합
            int sum2 = 0;
            for (int k = 1; k <= 10; k++)
            {
                if (k%2 == 0)
                {
                    sum2 += k; // sum2 = sum2 + i
                }
            }
            Console.WriteLine("1부터 10까지 짝수합 : " + sum2);

            //중첩 for문
            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine("a : "+a);
                for (int b = 1; b <= 4; b++)
                {
                    Console.WriteLine("b : "+b);
                    for (int c = 1; c <= 5 ; c++)
                    {
                        Console.WriteLine("c : "+c);
                    }
                }
            }
            //구구단
            for (int x = 2; x <= 9; x++)
            {
                Console.WriteLine("{0}단 시작", x);
                for (int y = 1; y <= 9; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}",x,y,z);
                }
            }

            //별삼각형
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine(); // 줄바꿈
            }
            //별삼각형(상하반대)
            for (int start = 10; start >= 1; start--)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine(); // 줄바꿈
            }

        }
    }
}
