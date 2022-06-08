﻿using CH05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 김상우
 * 내용 : 캡슐화 실습하기 교재 p 203
 * 
 */
namespace CH05
{
    internal class _2_Encaps
    {
        static void Main(string[] args)
        {
            // 객체 생성과 초기화(생성자 호출)
            Account kb = new Account("국민은행", "110-11-1234", "김유신", 1000);

            kb.Deposit(4000);
            kb.Withdraw(3000);

            // 캡슐화로 취약코드 예방
            // kb.balance--;
            // kb.balance += 10;

            kb.Show();

            Car sonata = new Car("소나타", "흰색", 0);
            Car bmw = new Car("BMW", "검정색", 0);
            Car benz = new Car("벤츠", "검정색", 0);

            // setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = -100;

            // getter 실행
            Console.WriteLine("sonata 객체 name : "+ sonata.Name);

            sonata.SpeedUp(60);
            sonata.Show();

            bmw.SpeedUp(50);
            bmw.Show();

            benz.SpeedUp(30);
            benz.Show();

        }
    }
}
