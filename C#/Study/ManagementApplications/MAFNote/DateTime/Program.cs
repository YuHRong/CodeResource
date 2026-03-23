/*
TimeOnly meetingTime = new TimeOnly(14, 30);    // 02:30PM
Console.WriteLine($"Meeting time: {meetingTime}");
*/

/*
TimeSpan duration = new TimeSpan(2, 0, 0);    // 2 hours
Console.WriteLine($"Event Duration: {duration}");
// Example console output: Event Duration: 02:00:00 
*/

/*
DayOfWeek today = DateTime.Now.DayOfWeek;/* 
Console.WriteLine($"Today is: {today}");

// Example console output: Today is: [DayOfWeek]
*/

/*
DateTimeOffset now = DateTimeOffset.Now;  // Get the current date and time with offset
Console.WriteLine($"Current date and time with offset: {now}");

DateTimeOffset utcNow = DateTimeOffset.UtcNow;  // Get the current UTC date and time with offset
Console.WriteLine($"Current UTC date and time with offset: {utcNow}");

DateTimeOffset futureDate = now.AddDays(10); // Add 10 days to the current date and time
Console.WriteLine($"Date 190 days from now: {futureDate}");

DateTimeOffset pastDate = now.AddHours(-5);  // Subtract 5 hours from the current date and time
Console.WriteLine($"Date 5 hours ago: {pastDate}");

TimeSpan difference = futureDate - now;
Console.WriteLine($"Difference between now and future date: {difference}", difference);
*/

/*
DateTime utcNow = DateTime.UtcNow;  // Get current UTC time
Console.WriteLine($"UTC now: {utcNow}");

DateTime estNow = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "Eastern Standard Time");  // Convert UTC to EST
Console.WriteLine($"EST Now: {estNow}");

TimeZoneInfo localZone = TimeZoneInfo.Local;  // Get local time zone
Console.WriteLine($"Local Time Zone: {localZone.DisplayName}");

DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone);  // Convert UTC to local time
Console.WriteLine($"Local Time: {localTime}");

TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific standard Time");  // Fine PST time zone
DateTime pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
Console.WriteLine($"PST Time: {pstTime}");
*/

/*
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
*/

/*
DateTime today = DateTime.Now; // Get the current date and time
DayOfWeek day = today.DayOfWeek; // Retrieve the current day of the week
Console.WriteLine("Today is: " + day);

DateTime nextSunday = today.AddDays(7 - (int)day); // Calculate the next Sunday
Console.WriteLine("Next Sunday is on: " + nextSunday.ToShortDateString());

bool isWeekend = day == DayOfWeek.Saturday || day == DayOfWeek.Sunday; // Check if today is a weekend
Console.WriteLine("Is today a weekend? " + isWeekend);
*/

/*
// Retrieve the current culture and UI culture
using System.Globalization;

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
*/

/*
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
*/

/*
DateTime date = new DateTime(2023, 1, 5);
CalendarWeekRule rule = CalendarWeekRule.FirstFourDayWeek;
DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
Console.WriteLine("Week of the year: " + weekOfYear);
*/

