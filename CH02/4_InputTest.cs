using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *날짜 : 2022/06/03
 *이름 : 김상우
 *내용 : C# 입력 실습하기 교재 p104
 */
namespace CH02
{
    internal class _4_InputTest
    {
        static void Main4(string[] args)
        {
            //이름입력
            Console.Write("이름:");
            string name = Console.ReadLine();

            //나이입력
            Console.Write("나이:");
            string age = Console.ReadLine();

            //주소입력
            Console.Write("주소:");
            string addr = Console.ReadLine();


            Console.WriteLine("==================");
            Console.WriteLine("이름 : "+name);
            Console.WriteLine("나이 : "+age);
            Console.WriteLine("주소 : "+addr);


        }
    }
}
