using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class p227
    {
        class Product
        {
            public string name = "default";
            public int price = 1000;
        }

        static void Main13(string[] args)
        {
            //인스턴스를 생성합니다.
            Product product = new Product();

            //인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            //인스턴스 변수를 출력합니다.
            Console.WriteLine(product.name + " : "+product.price +"원");
        }
    }
}
