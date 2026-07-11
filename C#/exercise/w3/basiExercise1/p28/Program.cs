// 
// Reverse Words in Sentence
// Write a C# program to reverse the words of a sentence.
// 

string? line;

Console.WriteLine("Input a string: ");
line = Console.ReadLine();

// 初始化变量保存翻转的单词
string reWord = "";

// 创建列表保存反转的字符串
List<string> wordList = new List<string>();

// 使用空格分割单词
string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

// 使用循环反转单词并创建新字符串
for (int i = words.Length - 1; i >= 0; i--)
{
 //通过按相反顺序添加单词来构建反向字符串
 reWord += words[i] + " ";
}

//将反向字符串添加到列表中
wordList.Add(reWord);

//循环打印列表中的反向字符串
foreach (string w in wordList)
{
 // 打印字符串
 Console.WriteLine($"\nReverse String: {w}");
}

for(int i = words.Length - 1; i >= 0; i--)
{
 Console.Write(words[i] + " ");
}