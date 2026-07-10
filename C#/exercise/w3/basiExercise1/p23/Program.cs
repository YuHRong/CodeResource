string? line;

Console.WriteLine("Input a string: ");
line = Console.ReadLine();

Console.WriteLine(line?.ToLower());