﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.Sub3
{
    class Banana
    {
        private string country;
        private int price;

        public Banana(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("바나나 원산지 : " + country);
            Console.WriteLine("바나나 가격 : " + price);
        }

    }
}
