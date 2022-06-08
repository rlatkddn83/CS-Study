using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class p209
    {
        static void Main2(string[] args)
        {
            //2
            Random random = new Random();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            //3
            Random random2 = new Random();
            Console.WriteLine(random2.NextDouble()*10);
            Console.WriteLine(random2.NextDouble()*10);
            Console.WriteLine(random2.NextDouble()*10);
            Console.WriteLine(random2.NextDouble()*10);
            Console.WriteLine(random2.NextDouble()*10);
        }
    }
}
