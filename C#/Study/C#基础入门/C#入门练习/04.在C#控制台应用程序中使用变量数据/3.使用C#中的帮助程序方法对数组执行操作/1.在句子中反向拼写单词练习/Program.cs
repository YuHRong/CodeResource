
string pangram = "The quick brown fox jumps over the lazy dog";

// 第壹部： 以空格拆分字符串
string[] msg = pangram.Split(' ');

// 第二部： 创建新字符串数组存储元字符串中的反向副本
string[] newMsg = new string[msg.Length];

// 第三步： 循环访问数组中的每个元素并反转，并存储在数组中
for (int i = 0; i < msg.Length; i++)
{
 char[] letters = msg[i].ToCharArray();
 Array.Reverse(letters);
 newMsg[i] = new string(letters);
}

// 第四部： 以空格连接字符串
string result = String.Join(' ', newMsg);
Console.WriteLine(result);
