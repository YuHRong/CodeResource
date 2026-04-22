string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0;
string message = "";

foreach (var value in values)
{
    decimal number;  // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"message: {message}");
Console.WriteLine($"total: {total}");