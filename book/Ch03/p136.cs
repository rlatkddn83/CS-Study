using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch03
{
    internal class p136
    {
        static void Main9(string[] args)
        {
            //9
            // 학점 변수
            double score = 3.6;
            // 조건을 구분합니다.
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score && score < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score && score < 3.5)
                Console.WriteLine("일반인");
            else if (2.3 <= score && score < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score && score < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score && score < 1.75)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= score && score < 1.0)
                Console.WriteLine("자벌레");
            else if (0 <= score && score < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");

            //10
            // 학점 변수
            double score2 = 3.6;

            // 조건을 구분합니다.
            if (score2 == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score2)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score2)
                Console.WriteLine("일반인");
            else if (2.3 <= score2)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score2)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score2)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= score2)
                Console.WriteLine("자벌레");
            else if (0 <= score2)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
        }
    }
}
