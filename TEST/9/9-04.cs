using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._9
{
    internal class _9_04
    {
        static void Main4(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (values[j] > values[j+1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                PrintArray(values);
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,5} {1}", arr[i], (i % 5 == 4) ? "\n" : "");
            }
        }
    }
}
