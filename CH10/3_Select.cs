﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    internal class _3_Select
    {
        static void Main(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "1q2w3e";
            string database = "testdb";

            // 데이터베이스 커넥션 생성
            string strconn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strconn);

            try
            {
                // 데이터베이스 접속
                conn.Open();
                Console.WriteLine("접속 성공...");

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료...");

            }

        }
    }
}
