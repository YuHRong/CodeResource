string? line;

Console.WriteLine("Input a string: ");
line = Console.ReadLine();

// 使用空格将字符串拆分为单词存储在数组中
string?[] words = line.Split(new[] { " " }, StringSplitOptions.None);

// 初始化一个空字符串以存储最大长度的单词
string word = "";

// 初始化计数器变量以存储最大长度
int count = 0;

// 遍历单词数组中的每个单词
foreach (var w in words)
{
 // 检查当前单词的长度是否大于存储的最大长度
 if (w?.Length > count)
 {
  //如果当前单词的长度较大，请更新“word”变量
  word = w;

  // 更新最大长度计数器
  count = w.Length;
 }
}

Console.WriteLine(word);