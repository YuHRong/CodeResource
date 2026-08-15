// Write a program in C# Sharp to count the total number of words in a string.

int word = 1;    // 初始化字符串单词统计变量，假设等于 1
Console.WriteLine("Inputh the string : ");
string? str = Console.ReadLine();

for (int i = 0; i < str.Length; i++)
{
 // 便利检查 i 是否是 空格、换行符、制表符
 if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
 {
  word++;    // 如果是空格换行符和制表符，则 word + 1
 }
}

// 显示字符串中单词总数
Console.Write("Total number of words in the string is: {0}\n", word);