// Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.
string userID = "123";
string password = "abc123";
string inputUserID;
string inputPassword;
int count = 3;
int c = 0;

do
{
 Console.Write("Input userID: ");
 inputUserID = Console.ReadLine();
 Console.Write("Input the password:");
 inputPassword = Console.ReadLine();

 count--;

 if (inputUserID == userID && inputPassword == password)
 {
  c = 1;
  Console.WriteLine("验证通过！成功登录");
  Console.ReadLine();
  break;
 }
 else // if (inputUserID != userID || inputPassword != password)
 {
  c = 0;
  if (count == 0)
  {
   Console.WriteLine("账号密码验证失败，回车退出\n");
   Console.ReadLine();
   break;
  }
  else
  {
   Console.WriteLine("输入错误，请重新输入！");
   Console.WriteLine($"你还可以输入 {count} 次\n");
  }
  continue;
 }
} while (count > 0);

/* if (c == 1)
{
 Console.WriteLine($"欢迎 {userID} 用户！");
}
else
{
 Console.WriteLine("账号密码错误，请选择，1. 找回账号。。\n2. 找回密码。\n");
} */cd p4
