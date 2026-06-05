
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// 分割字符串并保存在字符串数组中
string[] ordersNum = orderStream.Split(',');

// 按照字母排序
Array.Sort(ordersNum);

// 便利并访问字符串数组
foreach (string order in ordersNum)
{
 if (order.Length != 4)
 {
  Console.WriteLine($"{order}\t-\tError");
 }
 else
 {
  Console.WriteLine(order);
 }
}
