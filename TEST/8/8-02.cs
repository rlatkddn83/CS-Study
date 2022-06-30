using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._8
{
    internal class _8_02
    {
        static void Main2(string[] args)
        {
            Console.Write("키(cm) 입력 : ");
            double hight = double.Parse(Console.ReadLine());
            hight /= 100;

            Console.Write("몸무게(kg) 입력 : ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (hight * hight);

            string result;
            if (bmi < 20)
            {
                result = "저체중";
            }
            else if (bmi < 25)
            {
                result = "정상체중";
            }
            else if (bmi < 30)
            {
                result = "경도비만";
            }
            else if (bmi < 40)
            {
                result = "비만";
            }
            else
            {
                result = "고도비만";
            }

            Console.WriteLine("BMI={0:F1}, '{1}'임니다", bmi, result);
        }
    }
}
