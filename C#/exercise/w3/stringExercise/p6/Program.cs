string? str1, str2;
int count = 0;
int yes_no = 0;

Console.Write("\n\nCompare two strings whether they are equal or not:\n");
Console.Write("------------------------------------------------------\n");

Console.Write("Input the 1st string: "); ;
str1 = Console.ReadLine();
Console.Write("Input the nd string: ");
str2 = Console.ReadLine();

// 申明两个变量保存字符串的长度
int lengthStr1 = str1.Length;
int lengthStr2 = str2.Length;

// 检查两个字符串长度是否相等
if (lengthStr1 == lengthStr2)
{
 for (int i = 0; i < lengthStr1; i++)
 {
  if (str1[i] != str2[i])
  {
   yes_no = 1;
   i = lengthStr1;
  }
 }
}

if (lengthStr1 == lengthStr2)
{
 count = 0;
}
else if (lengthStr1 > lengthStr2)
{
 count = 1;
}
else
{
 count = -1;
}

if (count == 0)
{
 if (yes_no == 0)
  Console.Write("\nThe length of both strings are equal and both strings are same.\n\n");
 else
  Console.Write("\nThe length of both strings are equal but they are not same.\n\n");
}
else if (count == -1)
{
 Console.Write("\nThe length of the first string is smaller than the second.\n\n");
}
else
{
 Console.Write("\nThe length of the first string is greater than the second.\n\n");
}