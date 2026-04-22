string data = "Jim, Bob, Tom, Salad, John, 12, 15";
List<string> firstNames = data.Split(separator: ',').ToList();

foreach (var firstName in firstNames)
 Console.WriteLine(firstName);