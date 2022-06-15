using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 김상우
 * 내용 : 컬렉션 스택 실습
 */
namespace CH07
{
    internal class _1_Collection
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }



        }
    }
}
