
// 使用 DateOnly 打印开始练习时间。
using System.Globalization;

DateOnly practiceTime = new DateOnly(2026, 4, 5);
string practice = practiceTime.ToString("yy年M月d日");

Console.WriteLine($"欢迎使用我个人的小日历程序，\n本程序写于: {practice}");

// 提示用户输入现在时间，并打印不同时区的时间以及 Utc 标准时间。
// 提示用户输入日期和时间
Console.WriteLine("请输入现在的时间，格式为：年-月-日 时:分，例如： 2024-06-01 14:30");
DateTime enterDateTime = DateTime.Parse(Console.ReadLine() ?? string.Empty);
string enterDay = enterDateTime.ToString("yyyy年M月d日");
string enterTime = enterDateTime.ToString("HH:mm");

// 打印用户输入的时间
Console.WriteLine($"您输入的时间是: {enterDay} {enterTime}");

// 获取用户输入并打印当前标准 utc 时区和时间
  DateTime utcTime = enterDateTime.ToUniversalTime();
string utcTimeString = utcTime.ToString("yyyy年M月d日 HH:mm");

// 获取当前时区，并打印个时区和对应的时间
TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
TimeZoneInfo chineseTime = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
TimeZoneInfo japanTime = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
TimeZoneInfo 太平洋标准时间 = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
TimeZoneInfo 中部欧洲时间 = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

Console.WriteLine($"您对应的当前时区是: {localTimeZone.DisplayName}");
// Console.WriteLine($"您当前时区对应的 UTC 时间偏移是: {utcTimeString}");
Console.WriteLine($"中国标准时间是: {TimeZoneInfo.ConvertTime(enterDateTime, chineseTime).ToString("yyyy年M月d日 HH:mm")}");
Console.WriteLine($"日本标准时间是: {TimeZoneInfo.ConvertTime(enterDateTime, japanTime).ToString("yyyy年M月d日 HH:mm")}");
Console.WriteLine($"太平洋标准时间是: {TimeZoneInfo.ConvertTime(enterDateTime, 太平洋标准时间).ToString("yyyy年M月d日 HH:mm")}");
Console.WriteLine($"中部欧洲时间是: {TimeZoneInfo.ConvertTime(enterDateTime, 中部欧洲时间).ToString("yyyy年M月d日 HH:mm")}");

// 获取用户输入时间后，计算当前时间与用户输入的时间差，并打印出相差的天数、小时数和分钟数。
// 获取当前时间
DateTime timeNow = DateTime.Now;
TimeSpan timeDifference = timeNow - enterDateTime;
System.Console.WriteLine($"当前时间与您输入的时间相差: {timeDifference.Days}天 {timeDifference.Hours}小时 {timeDifference.Minutes}分钟");
// string dayNowString = timeDifference.ToString("yy:MM:dd");
// string timeNowString = timeDifference.ToString("hh:mm");
// Console.WriteLine($"当前时间与您输入的时间相差: {dayNowString}天 {timeNowString}");

// 计算今年已经过去的天数以及距离今年最后一天天数。
// 获取当前日期
Calendar calendar= CultureInfo.CurrentCulture.Calendar;
DateTime currentDate = DateTime.Now;
string[] chineseWeekDays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

Console.WriteLine($"今天是： {currentDate.ToString("yyyy年M月d日")}{chineseWeekDays[(int)currentDate.DayOfWeek]}。");
Console.WriteLine("今年已经过去： " + calendar.GetDayOfYear(currentDate) + " 天。");
Console.WriteLine("距离今年最后一天还有： " + (calendar.GetDaysInYear(currentDate.Year) - calendar.GetDayOfYear(currentDate)) + " 天。");

