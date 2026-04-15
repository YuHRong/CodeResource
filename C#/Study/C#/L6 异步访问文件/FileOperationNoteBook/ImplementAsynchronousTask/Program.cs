// 在 C# 中创建和调用异步任务的示例
/*
using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        string filePath = "example.txt";
        string content = await ReadFileAsync(filePath);
        Console.WriteLine(content);
    }

    public static async Task<string> ReadFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            return content;
        }
    }
}
*/

// 如何创建异步方法，以序列化 C# 对象、将 JSON 字符串写入文件、将文件内容读入字符串，并将 JSON 字符串反序列化回 C# 对象
/*
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class Account
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
}

public class Program
{
    public static async Task Main()
    {
        // Combine a directory and file name, then create the directory if it doesn't exist
        string directoryPath = @"C:\TempDir";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        string fileName = "account.json";
        string filePath = Path.Combine(directoryPath, fileName);

        Account account = new Account { Name = "Elize Harmsen", Balance = 1000.00m };

        // Save account data to a file asynchronously
        await SaveAccountDataAsync(filePath, account);

        // Load account data from the file asynchronously
        Account loadedAccount = await LoadAccountDataAsync(filePath);
        Console.WriteLine($"Name: {loadedAccount.Name}, Balance: {loadedAccount.Balance}");
    }

    public static async Task SaveAccountDataAsync(string filePath, Account account)
    {
        string jsonString = JsonSerializer.Serialize(account);
        await File.WriteAllTextAsync(filePath, jsonString);
    }

    public static async Task<Account> LoadAccountDataAsync(string filePath)
    {
        string jsonString = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<Account>(jsonString);
    }
}
*/

// 使用 HttpClient 向 REST API 发出异步 GET 请求并处理响应
/*
// Code that demonstrates the use of asynchronous REST API calls in C#

using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // PetStore API endpoint
                    string url = "https://petstore.swagger.io/v2/pet/findByStatus?status=available";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine($"Response: {responseBody}");

                    // Deserialize the JSON response into a list of pets
                    var pets = JsonSerializer.Deserialize<List<Pet>>(responseBody);

                    // Iterate through the list of pets and display their details
                    foreach (var pet in pets)
                    {
                        //Console.WriteLine($"Pet ID: {pet.id}, Name: {pet.name}");
                        if (pet.id.ToString().Length > 4)
                        {
                            Console.WriteLine($"Pet ID: {pet.id}, Name: {pet.name}");
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}
public class Pet
{
    public long id { get; set; }
    public string name { get; set; }
    public Category category { get; set; }
    public List<string> photoUrls { get; set; }
    public List<Tag> tags { get; set; }
    public string status { get; set; }
}

public class Category
{
    public long id { get; set; }
    public string name { get; set; }
}

public class Tag
{
    public long id { get; set; }
    public string name { get; set; }
}

*/

