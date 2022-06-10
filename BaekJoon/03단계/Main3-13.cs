using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_13
    {
        static void Main13(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string cal = Console.ReadLine();
                if (cal == null) { break; }
                else
                {
                    int rst = int.Parse(cal.Split()[0]) +int.Parse(cal.Split()[1]);
                    sb.Append(rst + "\n");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
