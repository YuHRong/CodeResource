using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
public class Employee
{
 public string Name { get; set; }
 public int Age { get; set; }
 public string Address { get; set; }
}

class Program
{
 static void Main()
 {
  var customer = new Employee { Name = "Anette Thomsen", Age = 30, Address = "123 Main St" };
  string jsonString = JsonSerializer.Serialize(customer);
  Console.WriteLine(jsonString);
  // Output: {"Name":"Anette Thomsen","Age":30,"Address":"123 Main St"}
 }
}
*/

/*
public class Employee
{
 public string Name { get; set; } = "Anette Thomsen";
 public int Age { get; set; }
 public string Address { get; set; } = "123 Main St";
}

class Program
{
 static void Main()
 {
  string jsonString1 = "{\"Name\":\"Anette Thomsen\",\"Age\":30,\"Address\":\"123 Main St\"}";
  string jsonString2 = @"{""Name"":""Anette Thomsen"",""Age"":30,""Address"":""123 Main St""}";
  var customer = JsonSerializer.Deserialize<Employee>(jsonString2);
  if (customer != null)
  {
   Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Address: {customer.Address}");
  }
  else
  {
   Console.WriteLine("Deserialization failed.");
  }
 }
}
// Output: Name: Anette Thomsen, Age: 30, Address: 123 Main St
*/

// 将对象转换为 JSON 字符串
// var customer = new Employee { Name = "Anette Thomsen", Age = 30, Address = "123 Main St" };
// string jsonString = JsonSerializer.Serialize(customer);

/*
public class WeatherForecastWithIgnoreAttribute
{
 public DateTimeOffset Date { get; set; }
 public int TemperatureCelsius { get; set; }
 [JsonIgnore]
 public string? Summary { get; set; }
}

class Program
{
 static void Main()
 {
  var forecast = new WeatherForecastWithIgnoreAttribute
  {
   Date = DateTimeOffset.Now,
   TemperatureCelsius = 25,
   Summary = "Warm"
  };

  string jsonString = JsonSerializer.Serialize(forecast);
  Console.WriteLine(jsonString);
  // Output: {"Date":"2023-10-01T12:00:00Z","TemperatureCelsius":25}
 }
}
*/

/*
namespace JsonIgnoreAttributeExample
{
 public class Forecast
 {
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
  public DateTime Date { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
  public int TemperatureC { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public string? Summary { get; set; }
 }

 public class Program
 {
  public static void Main()
  {
   Forecast forecast = new()
   {
    Date = default,
    Summary = null,
    TemperatureC = default
   };

   JsonSerializerOptions options = new()
   {
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
   };

   string forecastJson =
                   JsonSerializer.Serialize<Forecast>(forecast, options);

   Console.WriteLine(forecastJson);
  }
 }
}

// Produces output like the following example:
//{"TemperatureC":0}
*/

/*
class Program
{
 static void Main()
 {
  var customer = new BankCustomer { };
  File.WriteAllText("customer.json", jsonString);
  Console.WriteLine("JSON file created and saved.");
 }
}
*/

