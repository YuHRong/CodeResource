using System;
ing System.IO;

class Program
{
 // main方法

 static void Main(string[] args)
 {
  // 我们想要让用户一直有事情可做，所以用一个循环让菜单一直显示。

  while(true)   // 这句的意思是“一直做下面的事情，直到我说停”。
  {
   // 先告诉用户他们能干什么。
   Console.WriteLine("请选择操作：1. 写入文本 2. 读取文本 3. 退出");

   // 然后，耐心等待用户告诉我们他们的选择。

   string choice = Console.ReadLine();      // 选择

   // 根据用户的选择，做不同的事情。
   switch (choice)
   {
    case "1":     // 选择菜单1
     WriteToFile();     // 写入文本
     break;
    case "2":      // 选择菜单2
     ReadFromFile();   // 打开文件
     break;
    case "3":     // 选择菜单3
     Console.WriteLine("程序已退出");
     return;     // 结束方法
    default:     // 错误输入
     Console.WriteLine("无效的选择，请重新做出选择");
     break;
   }
  }
 }

 // 写入方法
  static void WriteToFile()
 {
  Console.WriteLine("请输入要保存的文本");     // 提示输入

  string content = Console.ReadLine();    // 准备读取输入

  // 使用StreamWriter，就像是打开了一个新笔记本准备写字。
  using(StreamWriter writer = new StreamWriter("textrecord.txt", true))
  {
   // 记录输入
   writer.WriteLine(content);
   Console.WriteLine("文本已保存");
  }
 }

 // 这个方法则是你的好奇宝宝朋友，帮你找出笔记本里写了啥。
 static void ReadFromFile()
 {
  // 检查文档是否还在

  if (File.Exists("textrecord.txt"))
  {
   Console.WriteLine("文件内容如下");

   // 使用StreamReader打开文档
   using (StreamReader reader = new StreamReader("textrecord.txt"))
   {

    string line;

    // 一行一行的读
    while((line = reader.ReadLine()) != null)
    {
     Console.WriteLine(line);
      // 显示文本内容
    }
   }

  }
  else
  {
   // 如果文件不存在
   Console.WriteLine("文件不存在");
  }
 }
}