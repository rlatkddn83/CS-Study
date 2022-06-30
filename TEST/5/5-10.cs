﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._5
{
    internal class _5_10
    {
        static void Main10(string[] args)
        {
            //배열
            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Array.Sort(arrNames);

            Console.WriteLine("배열");
            foreach (string name in arrNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            // 리스트
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            lstNames.Sort();

            Console.WriteLine("리스트");
            foreach (string name in lstNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
