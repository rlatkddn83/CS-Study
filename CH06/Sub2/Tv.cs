﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.Sub2
{
    internal class Tv : Internet, IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }
        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
    }
}
