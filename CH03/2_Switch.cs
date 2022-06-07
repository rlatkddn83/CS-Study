﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *날짜 : 2022/06/03
 *이름 : 김상우
 *내용 : 조건문 Switch 실습 교재 p127
 */
namespace CH03
{
    internal class _2_Switch
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("점수 입력 : ");
            string strScore = Console.ReadLine();

            int score = int.Parse(strScore);
            int grade = score / 10;

            switch (grade)
            {
                case 10:
                case 9:
                    Console.WriteLine("A입니다");
                    break;
                case 8:
                    Console.WriteLine("B입니다");
                    break;
                case 7:
                    Console.WriteLine("C입니다");
                    break;
                case 6:
                    Console.WriteLine("D입니다");
                    break;
                default:
                    Console.WriteLine("F입니다");
                    break;
            }
        }
    }
}
