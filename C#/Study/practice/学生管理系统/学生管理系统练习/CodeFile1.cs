using System;

class ArrowMenuDemo
{
 static void Main()
 {
  string[] menuItems = { "查询成绩", "添加成绩", "删除成绩", "退出系统" };
  int selectedIndex = 0;

  while (true)
  {
   Console.Clear();
   Console.WriteLine("=== 学生成绩管理系统 ===\n");
   Console.WriteLine("请使用 ↑ ↓ 键选择，回车确认：\n");

   // 显示菜单项
   for (int i = 0; i < menuItems.Length; i++)
   {
    if (i == selectedIndex)
    {
     Console.ForegroundColor = ConsoleColor.Green;
     Console.Write("> ");
    }
    else
    {
     Console.ResetColor();
     Console.Write("  ");
    }

    Console.WriteLine($"{i + 1}. {menuItems[i]}");
    Console.ResetColor();
   }

   // 读取按键
   ConsoleKeyInfo key = Console.ReadKey(true);

   switch (key.Key)
   {
    case ConsoleKey.UpArrow:
     selectedIndex = (selectedIndex - 1 + menuItems.Length) % menuItems.Length;
     break;

    case ConsoleKey.DownArrow:
     selectedIndex = (selectedIndex + 1) % menuItems.Length;
     break;

    case ConsoleKey.Enter:
     ExecuteMenuItem(selectedIndex);
     Console.WriteLine("\n按任意键返回菜单...");
     Console.ReadKey();
     break;

    case ConsoleKey.Escape:
     Console.WriteLine("\n确定要退出吗？ (Y/N)");
     if (Console.ReadKey().Key == ConsoleKey.Y)
      return;
     break;
   }
  }
 }

 static void ExecuteMenuItem(int index)
 {
  Console.WriteLine($"\n你选择了: 选项 {index + 1}");
  // 这里调用你实际的方法
  // switch(index) {
  //     case 0: GradeInquiry(); break;
  //     case 1: AddScore(); break;
  //     ...
  // }
 }
}