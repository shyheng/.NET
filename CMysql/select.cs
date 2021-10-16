using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMysql
{
    class select
    {
        static void Main()
        {
            String connetStr = "Persist Security Info=False;server=120.77.255.179;port=3306;user=root;password=1234; database=springboot;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            string sql = "select * from users";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
            while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
            {
                //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
                //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
                Console.WriteLine(reader.GetInt32("id") + reader.GetString("username") + reader.GetString("password"));//"userid"是数据库对应的列名，推荐这种方式
            };

        }
    }
}
