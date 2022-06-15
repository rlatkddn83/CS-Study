using CH07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 김상우
 * 내용 : 컬렉션 ArrayList 실습
 * 
 * ArrayList
 *  - 배열과 유사한 동적 선형 자료구조
 *  - List는 ArrayList를 일반화 시킨 자료구조 ArrayList보다 더 나은 성능
 */
namespace CH07
{
    internal class _3_ArrayList
    {
        static void Main3(string[] args)
        {
            // ArrayList 생성
            ArrayList list1 = new ArrayList();

            // 데이터 입력
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            // 데이터 삽입
            list1.Insert(1, 6);

            // 데이터 삭제
            list1.Remove(6);
            list1.RemoveAt(0);

            // 데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // 다양한  형석의 데이터를 갖는 ArrayList
            ArrayList list2 = new ArrayList();

            list2.Add(100);
            list2.Add(0.123);
            list2.Add(true);
            list2.Add('A');
            list2.Add("Apple");

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            /////////////////////////////////////////////
            /// List 교재 p211
            /////////////////////////////////////////////
            List<int> list3 = new List<int>();

            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);

            foreach(int n in list3)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();

            List<string> list4 = new List<string>();
            list4.Add("김유신");
            list4.Add("김춘추");
            list4.Add("장보고");
            list4.Add("강감찬");
            list4.Add("이순신");

            foreach (string name in list4)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            // 사과 객체 리스트
            List<Apple> list5 = new List<Apple>();

            list5.Add(new Apple("한국", 3000));
            list5.Add(new Apple("미국", 2000));
            list5.Add(new Apple("일본", 1000));

            Apple a1 = list5[0];
            a1.Show();
            list5[1].Show();
            list5[2].Show();

        }
    }
}
