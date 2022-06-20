using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/20
 * 이름 : 김상우
 * 내용 : 파일 입출력 실습하기
 */
namespace CH08
{

    internal class _3_FileIO
    {
        static void Main(string[] args)
        {
            /////////////////////////
            //파일입력(Read)
            /////////////////////////
            string path1 = "C:\\Users\\1302\\Desktop\\sample1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                // 스트림 생성
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                // 텍스트 하일 전용 보조 스트림 연결
                sr = new StreamReader(fs);

                // 파일 읽기
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 파일 닫기(자원 해제)
                sr.Close();
                fs.Close();
            }
            /////////////////////////
            //파일출력(Write)
            /////////////////////////
            string path2 = "C:\\Users\\1302\\Desktop\\sample2.txt";
            FileStream outfs = null;
            StreamWriter sw = null;

            try
            {
                // 스트림 생성
                outfs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(outfs);

                // 파일 쓰기
                sw.WriteLine("Welcome World!");
                sw.WriteLine("Welcome Korea!");
                sw.WriteLine("Welcome Busan!");

                for (int i = 2; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        sw.WriteLine("{0} * {1} = {2}", i, j, i * j);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 파일 닫기
                sw.Close();
                outfs.Close();
            }
            /////////////////////////
            //파일 읽기/쓰기
            /////////////////////////
            string f1 = "C:\\Users\\1302\\Desktop\\sample1.txt";
            string f3 = "C:\\Users\\1302\\Desktop\\sample3.txt";

            try
            {
                // using 선언으로 스트림 자원 해제 자동 실행
                using var reader = new StreamReader(new FileStream(f1, FileMode.Open));
                using var writer = new StreamWriter(new FileStream(f3, FileMode.Create));

                string txt;

                while ((txt = reader.ReadLine()) != null)
                {
                    writer.WriteLine(txt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("프로그램 종료...");
        }
    }
}
