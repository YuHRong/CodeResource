
Console.WriteLine("What is your name?");
var name = Console.ReadLine();

var currentDate = DateTime.Now;

Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:D} at {currentDate:t}!");

Console.Write($"{Environment.NewLine}Press Enter to exit...{Environment.NewLine}");

Console.Read();

Console.WriteLine($"GoodBye.{Environment.NewLine}");