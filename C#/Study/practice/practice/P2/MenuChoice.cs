using P2;
using static System.Console;

public class MenuChoice
{

 public void MenuCh()
 {
  while (true)
  {
   FileOperator file = new FileOperator();

   WriteLine("请选择操作\n1. 写入文本\n2. 读取文本\n3. 清空文本\n4. 退出\n");
   string? choice = ReadLine();

   switch (choice)
   {
    case "1":
     file.WriteFile();
     break;
    case "2":
     file.ReadFile();
     break;
    case "3":
     file.ClearFile();
     break;
    case "4":
     WriteLine("Bye.\n");
     return;
    default:
     WriteLine("输入错误，请重新输入\n");
     break;
   }
  }
 }
}