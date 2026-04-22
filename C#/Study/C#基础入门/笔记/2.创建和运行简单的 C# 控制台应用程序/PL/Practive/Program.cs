using System.Diagnostics;

string[] 欺诈性订单Id = {
 "B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

 foreach(string 订单号 in 欺诈性订单Id)
if (订单号.StartsWith("B"))
{
 Console.WriteLine(订单号);
}