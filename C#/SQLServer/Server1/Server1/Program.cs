using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Server1
{
 internal class Program
 {
  static void Main(string[] args)
   {
   // 连接数据库
   SqlConnection conn = new SqlConnection();

   conn.ConnectionString = "Server=localhost;database=TestDB;Trusted_Connection=true";

   conn.Open();

   SqlCommand cmd = new SqlCommand();

   cmd.Connection = conn;

   cmd.CommandText = "select * from UserT";

   SqlDataAdapter adapter = new SqlDataAdapter();

   adapter.SelectCommand = cmd;

   DataSet ds = new DataSet();

   adapter.Fill(ds);
   DataTable table = ds.Tables[0];  // 获取第一张表格

   for (int i = 0; i < table.Rows.Count; i++)
    Console.WriteLine($"{table.Rows[i]["UserName"]}  {table.Rows[i]["Password"]}  {table.Rows[i]["NickName"]}");
   Console.ReadKey();
  }
 }
}
