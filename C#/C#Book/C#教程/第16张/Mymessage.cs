//Mymessage.cs 源文件 用于定义程序显示的一些信息
using System;

namespace MyMessage
{
 public class Message
 {
  public static void Begin()
  {
   Console.WriteLine("***********       ***********");
   Console.WriteLine("*         *     *         *");
   Console.WriteLine("********** *   * * **********");
   Console.WriteLine("*         * * *   *         *");
   Console.WriteLine("*         *   *   *         *");
   Console.WriteLine("*         ** **   *");
   Console.WriteLine("*           ** *   *");
   Console.WriteLine("*             * *   *");
   Console.WriteLine("*               *");
   Console.WriteLine("*                 *");
   Console.WriteLine("*                   *");
   Console.WriteLine("*     SHAPE GAME    *");
   Console.WriteLine("***********************************");
  }

  public static bool Ask()
  {
   Console.WriteLine("Press 0 to exit the game");
   Console.WriteLine("Press any other key to continue the game");
   Console.WriteLine();
   int c = Console.Read();
   if (c == 48)
    return false;
   return true;
  }
 }
}