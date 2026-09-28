// Write a C# Sharp program to create a nested struct that stores two data for an employee.

using static System.Console;

class Program
{
 struct Employee
 {
  public string name;
  public dtObirth Date;
 }

 struct dtObirth
 {
  public int Year;
  public int Month;
  public int Day;
 }

 static void Main(string[] args)
 {
  //声明变量以存储日、月、年和员工总数
  int yy = 0, mm = 0, dd = 0;
  int total = 2;

  Write("\n\nCreate a nested structure and store data in an array :\n");
  Write("-------------------------------------------------------\n");

  //存储员工数组
  Employee[] emp = new Employee[total];

  //循环输入多个员工的数据
  for (int i = 0; i < total; i++)
  {
   // 输入员工信息（员工姓名）
   Write("Input of the employee name : ");
   string inputName = ReadLine();
   emp[i].name = inputName;

   // 员工生日（年）
   Write("Input Year of the birthDay : ");
   yy = Convert.ToInt32(ReadLine());
   emp[i].Date.Year = yy;
   // 月
   Write("Month of the birthDay : ");
   mm = Convert.ToInt32(ReadLine());
   emp[i].Date.Month = mm;
   // 日
   Write("Day of the birthDay : ");
   dd = Convert.ToInt32(ReadLine());
   emp[i].Date.Day = dd;
  }

  // 循环打印员工信息
  WriteLine("Name:\tBirthday(year-month-day)");
  for (int i = 0; i < total; i++)
  {
WriteLine($"{emp[i].name}\t\t{emp[i].Date.Year}-{emp[i].Date.Month}-{emp[i].Date.Day}");
  }
 }
}
