using P1;
using static System.Console;

MenuChoice();

// 菜单方法
static void MenuChoice()
{
 while (true)
 {
  WriteLine("请选择操作： \n1. 写入文本\n2. 读取文本\n3. 清空文本\n4.退出\n");

FileOp fileop = new FileOp();

  string choice = ReadLine();

  switch (choice)
  {
   case "1":
    fileop.WriteFile();
    break;
   case "2":
    fileop.ReadFile();
    break;
   case "3":
    fileop.ClearFile();
    break;
   case "4":
    WriteLine("Bye.\n");
    return;
   default:
    WriteLine("输入错误");
    break;
  }
 }
}

