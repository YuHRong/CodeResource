string str;
const int s = 200;
int[] chCount = new int[s];
int len, max = 0;

Console.Write("\n\nFind maximum occurring character in a string :\n");
Console.Write("--------------------------------------------------\n");
Console.Write("Input the string: ");
str = Console.ReadLine();
len = str.Length;

for (int i = 0; i < s; i++)
{//将所有字符的字符频率数组初始化为0
 chCount[i] = 0;
}

// 计算输入字符串中的每个字符的频率
for (int i = 0; i < len; i++)
{
 // 获取字符的 ASCII 值
 int ascii = (int)str[i];
 chCount[ascii] += 1;// 增加相同频率的计数
}

// 通过比较字符频率找到出现次数最多的字符
for (int i = 0; i < s; i++)
{
 if (i != 32) // 空格除外
 {
  if (chCount[i] > chCount[max])
  { // 检查当前频率是否大于最大值
   max = i;    // 以最大值更新字符索引
  }
 }
}

Console.WriteLine($"The Heighest frequency of character '{(char)max}' is appearing for number of times: {chCount[max]} \n");