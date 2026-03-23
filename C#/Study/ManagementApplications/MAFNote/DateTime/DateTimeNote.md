# 日期和时间

<div>

## DateOnly`、`TimeOnly`、`DateTime

这些类侧重于基本的日期和时间表示形式，适用于常见任务，例如计划和日志记录。

| 类名     | 说明                                                           |
| -------- | -------------------------------------------------------------- |
| DateOnly | ：需要处理日期而不考虑时间时（例如设置事件日期），请使用此类。 |
| TimeOnly | ：非常适合仅与时间相关的场景，例如安排每日会话。               |
| DateTime | ：最通用的结构，结合日期和时间，适用于常规计划任务。           |

### DateTime 示例

    TimeOnly meetingTime = new TimeOnly(14, 30); // 2:30 PM
    Console.WriteLine($"Meeting Time: {meetingTime}");

    // Example console output: Meeting Time: 14:30

`TimeOnly`，该对象表示没有日期的特定一天时间。 构造函数使用小时和分钟初始化时间，该方法以`Console.WriteLine`以可读格式输出到控制台

## DateTimeOffset`、`TimeZoneInfo`、`TimeSpan

这些类处理更复杂的方案，例如时区转换和间隔计算，提供精度和灵活性。

| 类名           | 说明                                                                                |
| -------------- | ----------------------------------------------------------------------------------- |
| DateTimeOffset | ：对于需要考虑不同时区的应用程序来说，它非常重要，因为它包含了相对于 UTC 的偏移量。 |
| TimeZoneInfo   | ：允许在不同时区之间转换时间，确保准确的计划。                                      |
| TimeSpan       | ：表示持续时间或间隔，可用于计算事件或中断的长度。                                  |

这些类附带用于在时区之间转换、调整偏移量以及对时间间隔执行算术的方法。 例如，`TimeSpan`提供用于添加、减去和比较时间间隔的方法。

示例: 

    TimeSpan duration = new TimeSpan(2, 0, 0); // 2 hours
    Console.WriteLine($"Event Duration: {duration}");

    // Example console output: Event Duration: 02:00:00

该示例演示如何创建和显示对象`TimeSpan`，说明时间间隔的概念。 它初始化`TimeSpan`时使用小时、分钟和秒，并以可读格式输出持续时间。

## DayOfWeek`、`CultureInfo`、`Calendar`、`CalendarWeekRule

这些类支持区域性特定的操作和特定的日期计算，对于国际化和基于日历的应用程序至关重要。

| 类名             | 说明                                                                                   |
| ---------------- | -------------------------------------------------------------------------------------- |
| DayOfWeek        | ：用于确定或比较特定日期的枚举，有助于进行每周计划。                                   |
| CultureInfo      | ：提供有关特定文化的信息，包括日期和时间格式规则，这些规则对于全球化应用程序至关重要。 |
| Calendar         | ：表示不同的日历系统，允许你在各种文化环境中处理日期。                                 |
| CalendarWeekRule | ：定义如何确定年份的第一周，对于依赖基于周的计算的应用程序非常有用。                   |

这些类提供根据文化规范格式化和解析日期时间的方法，以及在特定日历系统中进行日期计算的方法。

使用`DayOfWeek`的示例

    DayOfWeek today = DateTime.Now.DayOfWeek;
    Console.WriteLine($"Today is: {today}");

    // Example console output: Today is: [DayOfWeek]

该示例演示如何使用`DayOfWeek`枚举检索和显示星期中的当前日期。 它从当前日期和时间访问`DayOfWeek`该属性，并输出可读格式的结果。

</div>

---

<div>

## 使用偏移量、时区转换和时间间隔的日期和时间示例

### DateTimeOffset 方法

`DateTimeOffset`结构表示日期和时间，并用来显示与 UTC 差异的偏移量。 它非常适合需要精确识别特定时刻、执行日期和时间计算并维护各种相关时间的应用程序。
- 使用`DateTimeOffset`类型记录事务时间、系统或应用程序事件，以及文件创建和修改时间。
- 使用`DateTimeOffset`值执行算术运算来操控日期和时间，同时考虑其偏移量。

示例： 

    DateTimeOffset now = DateTimeOffset.Now; // Get the current date and time with offset
    Console.WriteLine($"Current date and time with offset: {now}");

    DateTimeOffset utcNow = DateTimeOffset.UtcNow; // Get the current UTC date and time with offset
    Console.WriteLine($"Current UTC date and time with offset: {utcNow}");

    DateTimeOffset futureDate = now.AddDays(10); // Add 10 days to the current date and time
    Console.WriteLine($"Date 10 days from now: {futureDate}");

    DateTimeOffset pastDate = now.AddHours(-5); // Subtract 5 hours from the current date and time
    Console.WriteLine($"Date 5 hours ago: {pastDate}");

    TimeSpan difference = futureDate - now; // Calculate the time difference between two dates
    Console.WriteLine($"Difference between now and future date: {difference}");

此代码演示如何为当前时间创建`DateTimeOffset`对象、检索 UTC 等效项、执行算术运算，例如添加天数或减去小时数，并计算两`DateTimeOffset`个值之间的差异。 这些方法为处理应用程序中的日期和时间数据提供了`DateTimeOffset`多才多艺的选择。

### TimeZoneInfo 方法

`TimeZoneInfo`类表示地球的任何时区，并使一个时区中的任何日期和时间转换为另一个时区中的等效时区。 它支持创建自定义时区以及时区信息的序列化和反序列化。
- 用于`TimeZoneInfo`在不同时区之间转换时间，确保日期和时间值明确标识单个时间点。
- 创建自定义时区并对其进行序列化以供以后使用。

示例： 

    DateTime utcNow = DateTime.UtcNow; // Get current UTC time
    Console.WriteLine($"UTC Now: {utcNow}");

    DateTime estNow = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "Eastern Standard Time"); // Convert UTC to EST
    Console.WriteLine($"EST Now: {estNow}");

    TimeZoneInfo localZone = TimeZoneInfo.Local; // Get local time zone
    Console.WriteLine($"Local Time Zone: {localZone.DisplayName}");

    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone); // Convert UTC to local time
    Console.WriteLine($"Local Time: {localTime}");

    TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"); // Find PST time zone
    DateTime pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone); // Convert UTC to PST
    Console.WriteLine($"PST Time: {pstTime}");

此示例演示如何将 UTC 时间转换为各种时区、检索本地时区，以及按 ID 查找特定时区。

### TimeSpand 方法

`TimeSpan`结构表示一个时间间隔，通常用于反映两个日期和时间值之间的时间间隔或测量已用时间。
- 使用`TimeSpan`计算两个`DateTime`值之间的差异，或使用`Stopwatch.Elapsed`属性测量已用的时间。
- 当表示不引用特定日期的时间时，将`DateTime`值替换为`TimeSpan`。

示例： 

    TimeSpan duration = new TimeSpan(2, 14, 18); // 2 hours, 14 minutes, 18 seconds
    Console.WriteLine($"Duration: {duration}");

    TimeSpan fromDays = TimeSpan.FromDays(1.5); // Create TimeSpan from 1.5 days
    Console.WriteLine($"From Days: {fromDays}");

    TimeSpan fromHours = TimeSpan.FromHours(5.75); // Create TimeSpan from 5.75 hours
    Console.WriteLine($"From Hours: {fromHours}");

    TimeSpan difference = TimeSpan.FromHours(10) - TimeSpan.FromMinutes(30); // Subtract intervals
    Console.WriteLine($"Difference: {difference}");

    TimeSpan multiplied = TimeSpan.FromMinutes(15) * 2; // Multiply interval
    Console.WriteLine($"Multiplied: {multiplied}");

此代码演示如何使用构造函数和工厂方法创建`TimeSpan`对象、执行算术运算以及以可读格式显示结果。

现在，可以使用`DateTimeOffset`记录带有 UTC 偏移量的时间、使用`TimeZoneInfo`进行时区转换，以及使用`TimeSpan`处理时间间隔。 这些工具可帮助你准确管理 .NET 应用程序中的日期和时间数据。

</div>

---

<div>

## 在 C 中应用 DayOfWeek、CultureInfo、Calendar 和 CalendarWeekRule#

### DayOfWeek 类方法

`DayOfWeek`枚举表示 C# 中的星期几。 它用于在 C# 应用程序中检索和处理星期几的信息。

示例： 

    DateTime today = DateTime.Now; // Get the current date and time
    DayOfWeek day = today.DayOfWeek; // Retrieve the current day of the week
    Console.WriteLine("Today is: " + day);

    DateTime nextSunday = today.AddDays(7 - (int)day); // Calculate the next Sunday
    Console.WriteLine("Next Sunday is on: " + nextSunday.ToShortDateString());

    bool isWeekend = day == DayOfWeek.Saturday || day == DayOfWeek.Sunday; // Check if today is a weekend
    Console.WriteLine("Is today a weekend? " + isWeekend);

在此示例中，该`DayOfWeek`属性检索当前日期、计算下一个星期日，并检查当前日期是否为周末。

`CultureInfo`类提供特定文化的信息，例如语言、国家/地区、日历以及与特定文化关联的约定。 此类对于在.NET 应用程序中处理特定于文化的数据至关重要。

示例： 

    // Retrieve the current culture and UI culture
    CultureInfo currentCulture = CultureInfo.CurrentCulture;
    CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
    Console.WriteLine("Current Culture: " + currentCulture.Name);
    Console.WriteLine("Current UI Culture: " + currentUICulture.Name);

    // Set a new culture and UI culture
    CultureInfo newCulture = new CultureInfo("fr-FR");
    CultureInfo.CurrentCulture = newCulture;
    CultureInfo.CurrentUICulture = newCulture;
    Console.WriteLine("New Culture: " + CultureInfo.CurrentCulture.Name);
    Console.WriteLine("New UI Culture: " + CultureInfo.CurrentUICulture.Name);

### Calendar 和 CalendarWeekRule 类方法

`Calendar`类表示以周、月和年等划分的时间。 它提供用于执行日历相关作的方法，例如获取月份中的天数或确定年份的周数。`CalendarWeekRule`枚举定义确定一年中第一周的规则，可与`Calendar.GetWeekOfYear`方法一起使用。

示例： 

    // Create a calendar instance
    Calendar calendar = CultureInfo.InvariantCulture.Calendar;

    // Get the number of days in February 2023
    int daysInMonth = calendar.GetDaysInMonth(2023, 2);
    Console.WriteLine("Days in February 2023: " + daysInMonth);

    // Determine the week of the year for December 31, 2023
    DateTime date = new DateTime(2023, 12, 31);
    CalendarWeekRule rule = CalendarWeekRule.FirstDay;
    DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
    int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
    Console.WriteLine("Week of the year for December 31, 2023: " + weekOfYear);

此示例演示如何使用`Calendar`类检索月份中的天数，并确定特定日期的年份周数。 这些`CalendarWeekRule`和`DayOfWeek`值用于定义如何在日历中分配周数。
`CalendarWeekRule`枚举定义了用于确定年度第一周的不同规则。 它与
`Calendar.GetWeekOfYear`该方法结合使用。

#### 定义年度的第一周

`CalendarWeekRule`枚举有三个值：
`FirstDay`、`FirstFullWeek`和`FirstFourDayWeek`

使用示例： 

    DateTime date = new DateTime(2023, 1, 5);
    CalendarWeekRule rule = CalendarWeekRule.FirstFourDayWeek;
    DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
    int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
    Console.WriteLine("Week of the year: " + weekOfYear);

在此示例中，`FirstFourDayWeek`规则用于确定年份的第一周。 一周可能会跨越两个年份，因此有一个规定，即作为一年中第一周的星期至少要有4天。
**`注意`这些`CalendarWeekRule`和`DayOfWeek`值一起使用来确定如何在日历中分配周数。**

现在，可以使用如`DayOfWeek`、`CultureInfo`、`Calendar`和`CalendarWeekRule`之类的类来管理 C# 中的日期和时间。 应用这些技能，以在应用程序中构建文化感知和基于日历的功能。

</div>
