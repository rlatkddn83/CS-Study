using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_04
    {
        static void Main4(string[] args)
        {
            int[] nums = new int[10];
            string ans = "";

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine()) % 42;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] == nums[j])
                        break;
                    else
                        a++;
                    if (a == i)
                    {
                        ans += nums[i-1]+" ";
                    }
                }
            }
            Console.WriteLine(ans.Split().Length);
        }
    }
}
