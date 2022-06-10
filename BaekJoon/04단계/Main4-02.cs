using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._04단계
{
    internal class Main4_02
    {
        static void Main2(string[] args)
        {
            int[] nums = new int[9];
            int max = 0;
            for (int i = 0; i < 9; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (i==1)
                {
                    if (nums[0] < nums[1])
                        max= 1;
                    else
                        max= 0;
                }
                else if(i > 1)
                {
                    if (nums[max] < nums[i])
                    {
                        max = i;
                    }
                }

            }
            Console.WriteLine(nums[max]);
            Console.WriteLine(max+1);

        }
    }
}
