using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_03
    {
        static void Main3(string[] args)
        {
            string ystr = Console.ReadLine();

            int yint = int.Parse(ystr);

            if(yint%4 != 0)
            { Console.WriteLine(0);}
            else if (yint%100 == 0)
            { 
                if(yint %400 == 0)
                { Console.WriteLine(1);}
                else
                { Console.WriteLine(0);}
            }
            else
            { Console.WriteLine(1);}
        }
    }
}
