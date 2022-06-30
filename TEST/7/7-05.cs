using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._7
{
    internal class _7_05
    {
        static void Main5(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);
            
            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);
            
            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);
            
            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);
            
            result = (first == second || (first > 5));
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second && (first > 5));
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = (true ^ false);
            Console.WriteLine("{0} ^ {1} : {2}", true, false, result);




            
        }
    }
}
