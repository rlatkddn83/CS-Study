﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05.Sub5
{
    internal class Eagle : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Eagle Fly...");
        }
        public void Hunt()
        {
            Console.WriteLine("Eagle Hunt...");
        }

    }
}
