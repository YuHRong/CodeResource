using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

class Program
{
 static List<(string name, string course, int score)> studentsInformation;

 static void Main(string[] args)
 {
  //初始化全局列表
  studentsInformation = new List<(string name, string course, int score)>();

  //启动后加载已有数据
  LoadDataFromFile();

  //菜单选项
  while (true)
  {
   Console.WriteLine("请选择菜单进行操作:");
   Console.WriteLine("1. 查询成绩");
   Console.WriteLine("2. 添加成绩");
   Console.WriteLine("3. 从内存读取成绩");
   Console.WriteLine("0. 退出");

   string menu = Console.ReadLine();

   //菜单选择
   switch (menu)
   {
    case "1":
     ReadFromFile();
     break;
    case "2":
     AddScore();
     break;
    case "3":
     GradeInquiry1();
     break;
    case "0":
     Console.WriteLine("已退出。");
     return;
    default:
     Console.WriteLine("请重新输入!");
     break;
   }
  }
 }

  //查询成绩方法
  static void GradeInquiry()
  {
   ReadFromFile();
  }

  //添加成绩方法
  static void AddScore()
  {
   //添加学生信息
   Console.WriteLine("请输入学生成绩信息。\n格式为:名字，课程，成绩。\n中间用中英文逗号: \",，\" 或者句号 \".。\"分隔。");

   while (true)
   {
    string inputStudent = Console.ReadLine();

    if (inputStudent == "exit")
     return;

    //分割输入
    string[] parts = inputStudent.Split(',', '，', '.', '。');
    if (parts.Length != 3)
    {
     Console.WriteLine("输入错误，格式为：\n姓名,课程,成绩");
     continue;
    }

    string name = parts[0].Trim();
    string course = parts[1].Trim();

    if (!int.TryParse(parts[2].Trim(), out int score))
    {
     Console.WriteLine("请输入整数。");
     continue;
    }

    //验证输入
    if (string.IsNullOrWhiteSpace(name))
    {
     Console.WriteLine("姓名不能为空。");
     continue;
    }

    if (string.IsNullOrWhiteSpace(course))
    {
     Console.WriteLine("课程不能为空。");
     continue;
    }

    if (score < 0 || score > 100)
    {
     Console.WriteLine("请输入1 到 100。");
     continue;
    }

    //添加列表
    studentsInformation.Add((name, course, score));

    //调用保存方法
    SaveToFile(name, course, score);

    Console.WriteLine($"你添加的学生信息为,姓名: {name}, 课程: {course}, 成绩: {score}");
    Console.WriteLine("回车返回主菜单。");
    Console.ReadLine();
    break;
   }
  }

  //创建写入方法
  static void SaveToFile(string name, string course, int score)
  {
   using (StreamWriter writer = new StreamWriter("StudentScore.txt", true))
   {
    writer.WriteLine($"{name},{course},{score}");
   }
  }

  //查询方法
  static void ReadFromFile()
  {
   //检查文件
   if (File.Exists("StudentScore.txt"))
   {
    Console.WriteLine("学生成绩如下:");

    // 打开文件
    using (StreamReader reader = new StreamReader("StudentScore.txt"))
    {
     string line;

     while ((line = reader.ReadLine()) != null)
     {
      Console.WriteLine(line);
      //显示成绩信息
     }
    }
   }
   else
   {
    //如果文件不存在
    Console.WriteLine("文件不存在。");
   }
  }

 //显示内存中的 studentInformation
 static void GradeInquiry1()
 {
  Console.WriteLine("\n=== 所有学生成绩（内存中的数据）===");

  if (studentsInformation.Count == 0)
  {
   Console.WriteLine("暂无学生成绩记录");
   return;
  }

  for(int i = 0; i < studentsInformation.Count; i++)
  {
   var student = studentsInformation[i];
   Console.WriteLine($"{i + 1}. 姓名:{student.name},课程:{student.course},成绩:{student.score}");
  }

  Console.WriteLine("按回车返回主菜单...");
  Console.ReadLine();
 }

 //加载文件方法
static void LoadDataFromFile()
 {
  if (!File.Exists("StudentScore.txt"))
  {
   Console.WriteLine("数据文件不存在，将创建新文件");
   return;
  }

  try
  {
   string[] lines = File.ReadAllLines("StudentScore.txt");
   foreach(string line in lines)
   {
    string[] parts = line.Split(',');
    if(parts.Length >= 3)
    {
     string name = parts[0].Trim();
     string course = parts[1].Trim();
     if (int.TryParse(parts[2].Trim(), out int score))
     {
      studentsInformation.Add((name, course, score));
     }
    }
   }
   Console.WriteLine($"已加载 {studentsInformation.Count} 条记录");
  }
  catch (Exception ex)
  {
   Console.WriteLine($"加载数据时出错: {ex.Message}");
  }
 }
}
