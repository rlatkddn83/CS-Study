using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_04
    {
        static void Main(string[] args)
        {
            int innum = int.Parse(Console.ReadLine());
            string[] calnum = new string[2];
            
            List<int> list = new List<int>();


            for (int i = 0; i < innum; i++)
            {
                calnum = Console.ReadLine().Split();
                int result = int.Parse(calnum[0]) + int.Parse(calnum[1]);

                list.Add(result);
            }

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            
        }
    }
}