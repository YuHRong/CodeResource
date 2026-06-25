using static System.Console;

namespace P2;

public class FileOperator
{

 // 写入文本方法
 public void WriteFile()
 {
  WriteLine("请输入文本： \n");

  string input = ReadLine();

  // 使用 StreamWriter 写入文本
  using (StreamWriter writer = new StreamWriter("test.txt", true))
  {
   // 写入文本
   writer.WriteLine(input);
   WriteLine("写入成功");
  }
 }

 // 读取文件方法
 public void ReadFile()
 {

  // 检查文件是否还在
  if (File.Exists("test.txt"))
  {
   // 使用 StreamReader 打开文档
   using (StreamReader reader = new StreamReader("test.txt"))
   {
    string line;

    // 逐行读取
    while ((line = reader.ReadLine()) != null)
    {
     // 显示文本内容
     WriteLine(line);
    }

    reader.Close();
   }
  }
 }

 // 清除文本
 public void ClearFile()
 {
  File.WriteAllText("test.txt", string.Empty);
  WriteLine("文件以清空。\n回车返回\n");
  Read();
 }

}

