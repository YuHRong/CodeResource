//添加学生姓名
//List<string> sName = new List<string>();
//LinkedListNode//List<string> course = new List<string>();    //添加课程信息
//List<int> sores = new List<int>();    //添加成绩
//using Microsoft.VisualBasic;
List<(string, string, int)> studentsInformation = new List<(string, string, int)>();


//菜单选项
while (true)
{
 Console.WriteLine("请选择菜单进行操作:");
 Console.WriteLine("1. 查询成绩");
 Console.WriteLine("2. 添加成绩");
 Console.WriteLine("0. 退出");

 string menu = Console.ReadLine();

 //菜单选择
 switch (menu)
 {
  case "1":
   GradeInquiry();
   break;
  case "2":
   AddScore();
   break;
  case "0":
   Console.WriteLine("已退出。");
   return;
  default:
   Console.WriteLine("请重新输入!");
   break;
 }
}

//查询成绩方法
void GradeInquiry()
{
 ReadFromFile();
}

//添加成绩方法
void AddScore()
{
 //添加学生信息
 Console.WriteLine("请输入学生姓名，回车继续，输入exit退出");
 //string inputName = Console.ReadLine();
 string studentInformation = Console.ReadLine();
 if (studentInformation == "exit")
  return;

 if (!string.IsNullOrWhiteSpace(studentInformation))
 {
  studentInformation.Add(studentInformation);
 }

 //添加课程信息
 //Console.WriteLine("请输入课程名称，输入exit退出");

 //string inputCourse = Console.ReadLine();

 //if (!string.IsNullOrWhiteSpace(inputCourse))
 {
  //course.Add(inputCourse);
 }
 //if (inputCourse == "exit")

  //return;
 //添加成绩
 //Console.WriteLine("请输入成绩，exit退出");


 //if (sScore == "exit")
  //return;
 //if (int.TryParse(sScore, out int score))
 {
  //scores.Add(score);
 }
 //else
  //Console.WriteLine("请重新输入。");

 //保存方法
 SaveToFile(studentInformation);

 Console.WriteLine("成绩已添加。");
}
 string studentInformations = Console.ReadLine();

void SaveToFile(string name, string course, int score)
{
 using (StreamWriter writer = new StreamWriter("StudentScore.xaml", true))
 {
  writer.WriteLine($"{studentInformations}");
 }
}

//查询方法
void ReadFromFile()
{
 //检查文件

 if (File.Exists("StudentScore.xaml"))
 {
  Console.WriteLine("学生成绩如下:");

  // 打开文件
  using (StreamReader reader = new StreamReader("studentScore.xaml"))
  {

   string line;

   while((line = reader.ReadLine()) != null)
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

