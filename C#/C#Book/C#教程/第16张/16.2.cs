// 客户程序源文件
using System;
using MyProgram.CSharp.FistrApp;

class WelcomeApp
{
 public static void Main()
 {
  WelcomeMessage M = new WelcomeMessage();
   System.Console.WriteLine(M.Message);

  System.Console.WriteLine("Please enter your name");
  string input = System.Console.ReadLine();

  M.Message = "Welcome, " + input + "!";
  System.Console.WriteLine(M.Message);
 }
}