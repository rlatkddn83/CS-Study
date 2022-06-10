using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._2
{
    internal class _2_06
    {
        public static void Intro()
        {
            Console.WriteLine("******* STAR *******");
            Console.WriteLine("두개의 정수를 입력");
        }
        public static int Input(char name)
        {
            Console.Write("변수 " + name + " 값 입력 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static void Result(int val)
        {
            Console.WriteLine("덧셈 결과 : " + val);
            Console.WriteLine("******* END *******");
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        static void Main6(string[] args)
        {
            Intro();

            int a = Input('a');
            int b = Input('b');

            int output = add (a, b);
            Result(output);
        }
    }
}
