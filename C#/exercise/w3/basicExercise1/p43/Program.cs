// Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".

Console.Write("Input a string : ");
string str = Console.ReadLine();

bool isW = true;

for (int i = 0; i < str.Length - 1; i++)
{
 if (str[0] == 'w')
 {
  if (str.Substring(0, 3).Equals("ww"))
   isW = true;
  else isW = false;
 }
 else
  isW = false;
}

Console.WriteLine(isW);