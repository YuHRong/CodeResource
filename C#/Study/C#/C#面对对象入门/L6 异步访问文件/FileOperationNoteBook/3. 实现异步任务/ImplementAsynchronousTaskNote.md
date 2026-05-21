# 异步编程入门

通过使用异步编程技术，可以提高应用程序的效率和响应能力，就像一次执行多个任务来更高效地做早餐一样。

异步性对于可能会导致阻塞的活动（例如 Web 访问）至关重要。 有时，对 Web 资源的访问速度缓慢或延迟。 如果在同步进程中阻止此类活动，则整个应用程序必须等待。 在异步进程中，应用程序可以继续执行其他不依赖于 Web 资源的工作，直到潜在的阻塞任务完成。

下表显示了异步编程提高响应能力的典型区域。 .NET 和 Windows 运行时中列出的 API 包含支持异步编程的方法。

| 应用程序区域 | 使用异步方法的 .NET 类型                        | 使用异步方法的 Windows 运行时类型              |
| ------------ | ----------------------------------------------- | ---------------------------------------------- |
| 网络访问     | HttpClient                                      | Windows.Web.Http.HttpClient、SyndicationClient |
| 使用文件     | JsonSerializer、StreamReader、StreamWriter 等。 | StorageFile                                    |
| 使用映像     |                                                 | MediaCapture、BitmapEncoder、BitmapDecoder     |
| WCF 编程     | 同步和异步操作                                  |

## 如何创建和调用异步方法

在 C# 中，异步操作是使用`async`和`await`关键字实现的。 关键字`async`用于定义异步方法，而`await`关键字用于调用异步方法并等待其结果而不阻止调用线程。 异步操作通常使用`Task`或`Task<T>`类型来实现，这些类型表示可以等待的进行中的操作。

示例： 

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

在这个示例中， `ReadFileAsync` 方法使用 `async` 关键字定义，并具有 `Task<string>` 的返回类型。 `async ` 关键字表示该方法包含异步操作，而 `Task<string>` 的返回类型表示该方法返回一个表示异步操作的任务。

`Task<string>` 类型是一个泛型任务，表示返回字符串值的异步操作。
`ReadFileAsync`方法接受一个文件路径作为参数，并异步读取文件内容。
`Main`方法也被定义为异步的，允许它使用`await`关键字调用
`ReadFileAsync`方法。`await`关键字用于指示程序应在继续之前等待异步操作的结果。

在这种情况下，程序会等待文件被读取后，才将其内容打印到控制台。

## 实现异步文件输入和输出

在 C#中，文件输入和输出（文件 I/O）可以同步执行，也可以异步执行。

异步文件 I/O 特别适用于提高应用程序的性能和响应能力，尤其是在文件操作可能需要大量时间的场景中，例如读取大文件或将数据写入硬盘。

## 创建用于读取和写入文件的异步方法

C#中的`async`和`await`关键字允许您创建可以执行文件 I/O 操作的异步方法，而不会阻塞主线程。

这在具有用户界面的应用程序中特别有用，因为阻塞主线程会导致界面冻结或不响应。`System.IO`和`System.Text.Json`命名空间提供了用于执行异步文件 I/O 操作的类和方法。

`System.IO`命名空间中的`File`类提供异步读取和写入文件的方法。

`File.ReadAllTextAsync`该方法以异步方式读取文件的内容，而`File.WriteAllTextAsync`该方法以异步方式将文本写入文件。 这些方法返回一个
`Task<string>`或`Task`表示异步操作，允许你使用`await`关键字等待其完成，而不会阻止调用线程。

在`System.Text.Json`命名空间中。`JsonSerializer`类提供用于序列化和反序列化 JSON 数据的异步方法。`JsonSerializer.SerializeAsync`方法以异步方式将对象序列化为 JSON 字符串，而`JsonSerializer.DeserializeAsync`该方法以异步方式将 JSON 字符串反序列化为对象。 这些方法还返回一个`Task`，用于表示异步操作。

示例：如何创建异步方法，以序列化 C# 对象、将 JSON 字符串写入文件、将文件内容读入字符串，并将 JSON 字符串反序列化回 C# 对象：

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

在此示例中`SaveAccountDataAsync`方法将对象`Account`序列化为 JSON 字符串，并将其异步写入文件。`LoadAccountDataAsync`方法异步地从文件中读取 JSON 字符串，并将其反序列化为`Account`对象。`Main`方法演示如何使用`await`关键字调用这些异步方法。

`Directory.CreateDirectory`此方法用于创建目录（如果不存在），确保文件可以成功写入。

## Web 资源

对 Web 资源的调用可能会导致用户长时间等待。 为了避免阻止用户界面（UI）线程，可以异步访问 Web 资源。

Web 资源是可通过 Internet 访问的任何数据或服务。 这包括网页、应用程序编程接口（API）、图像、视频和其他类型的内容。 应用程序使用标准 Web 协议（如超文本传输协议（HTTP）或 HTTP 安全（HTTPS）检索或与 Web 资源交互。

访问 Web 资源的一个常见用例是从远程服务器或服务检索数据。 这包括提取 JSON 或 XML 数据、下载文件或与 Web API 交互。 例如，你可能想要访问天气 API 以获取特定位置的当前天气条件，或者可能需要从 URL 下载图像。

表示性状态传输（REST）API 是访问 Web 资源的一种常用方法，因为它们提供了一种标准化的方式，用于使用 GET、POST、PUT 和 DELETE 等 HTTP 方法与 Web 服务交互。 REST API 在 Web 开发、移动应用程序和云服务中广泛使用，以实现不同平台之间的数据交换和集成。 REST API 通常以 JavaScript 对象表示法（JSON）格式返回数据，这是轻量级且易于分析的数据。

在 C# 中，可以使用`HttpClient`类向 Web 资源发出 HTTP 请求。

`HttpClient`类是 `System.Net.Http`命名空间的一部分，该命名空间提供用于发送 HTTP 请求和接收 HTTP 响应的类。`HttpClient`类旨在异步使用，使你能够对 Web 资源进行非阻止调用。

HTTPClient类包括以下异步方法

| 方法名      | 说明                                                   |
| ----------- | ------------------------------------------------------ |
| GetAsync    | ：将 GET 请求发送到指定的 URI 并返回响应。             |
| PostAsync   | ：使用指定内容向指定 URI 发送 POST 请求，并返回响应。  |
| PutAsync    | ：使用指定内容将 PUT 请求发送到指定 URI 并返回响应。   |
| DeleteAsync | ：将 DELETE 请求发送到指定的 URI 并返回响应。SendAsync | ：发送 HTTP 请求消息并返回响应。 |

下面的示例演示如何使用`HttpClient`类向 REST API 发出异步 GET 请求并处理响应

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

在此示例中，`HttpClient`类用于向 PetStore API 发送异步 GET 请求。 响应被读取为字符串，并使用`Pet`类反序列化为`JsonSerializer`对象的列表。 然后，该代码循环访问宠物列表并显示其详细信息。`using`语句确保`HttpClient`实例在使用后得到正确处理，释放其占用的资源。
`HttpClient`类设计用于多个请求重复使用，因此建议创建一个`HttpClient`实例并在整个应用程序中使用。 这有助于通过重用基础网络连接来提高性能和资源管理。

## 并行运行异步任务

并行编程是一种功能强大的技术，可用于同时执行多个任务，从而提高应用程序的性能和响应能力。

在 C# 中，可以使用任务并行库 （`TPL`） 简化并行代码编写过程。 TPL 是`System.Threading`和`System.Threading.Tasks`命名空间中的一组公共类型和 API。`TPL` 的目的是通过简化向应用程序添加并行度和并发的过程，提高开发人员的工作效率。 `TPL` 动态缩放并发程度，以最高效地使用所有可用的处理器。 此外，`TPL` 还处理`工作分区`、`ThreadPool 上的线程计划`、`取消支持`、`状态管理`和`其他低级别详细信息`。 通过使用 `TPL`，你可以最大程度地提高代码的性能，同时专注于程序旨在完成的工作。

TPL 在以下方面提供支持:
- 数据并行：任务并行库（TPL）提供执行数据并行的方法，使你能够同时对多个数据元素执行相同的操作。 当你拥有大型数据集并且想要单独对每个元素执行计算或转换时，这特别有用。
- 基于任务的异步编程模型：TPL 提供`Task`类，表示异步操作。 可以使用`async`和`await`关键字来简化编写异步代码的过程。 这样，就可以编写更易于读取和维护的代码，同时仍利用并行度。
- 数据流：TPL 提供数据流编程模型，可用于创建复杂的数据处理管道。 此模型基于“块”的概念，可以异步处理数据并使用消息相互通信。

### 数据并行

数据并行是一种并行编程模式，侧重于同时对多个数据元素执行相同的操作。 当你拥有大型数据集并且想要单独对每个元素执行计算或转换时，这特别有用。 在 C# 中，可以使用`Parallel.For`和`Parallel.ForEach`方法轻松实现数据并行。 通过这些方法，可以并行循环访问集合或数据范围，并将工作负荷分布到多个线程。

任务并行库通过`System.Threading.Tasks.Parallel`类支持数据并行。 此类提供基于方法的`for`和`foreach`循环的并行实现。 为`Parallel.For`循环或`Parallel.ForEach`循环编写循环逻辑时，就像编写顺序循环一样。 TPL 为你处理所有低级别工作。

下面的代码示例演示了一个简单的 foreach 循环及其并行等效项。

    // Sequential version
    foreach (var item in sourceCollection)
    {
        Process(item);
    }

    // Parallel equivalent
    Parallel.ForEach(sourceCollection, item => Process(item));

TPL 还提供一组数据结构，这些结构针对并发访问进行了优化，例如`ConcurrentBag`，`ConcurrentQueue`和`ConcurrentDictionary`。 借助这些数据结构，可以安全地添加、删除和访问多个线程中的元素，而无需显式锁定。

下面的代码示例演示如何使用 a`ConcurrentBag`来存储并行运行的多个任务的结果：

    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var results = new ConcurrentBag<int>();
            Parallel.For(0, 100, i =>
            {
                // Simulate some work
                Task.Delay(100).Wait();
                results.Add(i);
            });

            Console.WriteLine($"Processed {results.Count} items in parallel.");
        }
    }

在此示例中，`ConcurrentBag`用于存储并行处理的结果。 每个任务都会将其结果添加到包中，而无需显式锁定，确保线程安全。

### 使用 `Task.WhenAll` 和 `Task.WhenAny` 并行运行任务

Task.WhenAll `Task.WhenAny`方法是 C# 中任务并行库的一部分。 这些方法允许并行运行多个任务，并等待其完成。

`Task.WhenAll`用于当你想要等待所有任务完成后再继续时。 它采用任务数组作为输入，并返回表示所有输入任务的完成的单个任务。 如果有多个可以并发执行的独立任务，例如进行多个 API 调用或同时处理多个文件，这非常有用。如果想要等待任何任务完成，可以使用`Task.WhenAny`。 它采用任务数组作为输入，并返回表示完成的第一个任务的任务。 如果想要在完成任何任务后立即执行某些操作，而无需等待所有任务完成，这非常有用。

下面的代码示例演示如何用于`Task.WhenAll`并行运行多个任务并等待其完成：

    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    class Program
    {
        static async Task Main(string[] args)
        {
            var urls = new List<string>
            {
                "https://example.com",
                "https://example.org",
                "https://example.net"
            };

            var tasks = new List<Task<string>>();

            foreach (var url in urls)
            {
                tasks.Add(FetchDataAsync(url));
            }

            // Wait for all tasks to complete
            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        static async Task<string> FetchDataAsync(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }

在此示例中，该方法`FetchDataAsync`使用`Task.WhenAll`从多个 URL 并行提取数据。 完成所有任务后，结果将打印到控制台。

### 同时进行多个文件 I/O 操作

在许多情况下，文件迭代是一个可以轻松进行并行化的操作。

以下示例按顺序循环访问目录，但并行处理文件。 如果文件与目录比率较大，这可能是最佳方法。 还可以并行化目录迭代，并按顺序访问每个文件。 除非你专门面向具有大量处理器的计算机，否则并行化这两个循环可能并不有效。 但是，与在所有情况下一样，应全面测试应用程序，以确定最佳方法。

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Security;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            try
            {
                TraverseTreeParallelForEach(@"C:\Program Files", (f) =>
                {
                    // Exceptions are no-ops.
                    try
                    {
                        // Do nothing with the data except read it.
                        byte[] data = File.ReadAllBytes(f);
                    }
                    catch (FileNotFoundException) { }
                    catch (IOException) { }
                    catch (UnauthorizedAccessException) { }
                    catch (SecurityException) { }
                    // Display the filename.
                    Console.WriteLine(f);
                });
            }
            catch (ArgumentException)
            {
                Console.WriteLine(@"The directory 'C:\Program Files' does not exist.");
            }

            // Keep the console window open.
            Console.ReadKey();
        }

        public static void TraverseTreeParallelForEach(string root, Action<string> action)
        {
            //Count of files traversed and timer for diagnostic output
            int fileCount = 0;
            var sw = Stopwatch.StartNew();

            // Determine whether to parallelize file processing on each folder based on processor count.
            int procCount = Environment.ProcessorCount;

            // Data structure to hold names of subfolders to be examined for files.
            Stack<string> dirs = new Stack<string>();

            if (!Directory.Exists(root))
            {
                throw new ArgumentException(
                    "The given root directory doesn't exist.", nameof(root));
            }
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs = { };
                string[] files = { };

                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                // Thrown if we do not have discovery permission on the directory.
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Thrown if another process has deleted the directory after we retrieved its name.
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                // Execute in parallel if there are enough files in the directory.
                // Otherwise, execute sequentially.Files are opened and processed
                // synchronously but this could be modified to perform async I/O.
                try
                {
                    if (files.Length < procCount)
                    {
                        foreach (var file in files)
                        {
                            action(file);
                            fileCount++;
                        }
                    }
                    else
                    {
                        Parallel.ForEach(files, () => 0,
                            (file, loopState, localCount) =>
                            {
                                action(file);
                                return (int)++localCount;
                            },
                            (c) =>
                            {
                                Interlocked.Add(ref fileCount, c);
                            });
                    }
                }
                catch (AggregateException ae)
                {
                    ae.Handle((ex) =>
                    {
                        if (ex is UnauthorizedAccessException)
                        {
                            // Here we just output a message and go on.
                            Console.WriteLine(ex.Message);
                            return true;
                        }
                        // Handle other exceptions here if necessary...

                        return false;
                    });
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            }

            // For diagnostic purposes.
            Console.WriteLine($"Processed {fileCount} files in {sw.ElapsedMilliseconds} milliseconds");
        }
    }

在此示例中，文件 I/O 是同步执行的。 当代码使用大型文件或网络连接缓慢时，最好以异步方式访问文件。 可以将异步 I/O 技术与并行迭代相结合。

该示例使用本地 fileCount 变量来维护已处理的文件总数的计数。 由于变量可由多个任务并发访问，因此通过调用`Interlocked.Add`该方法来同步访问。

请注意，如果在主线程上引发异常，则 ForEach 方法启动的线程可能会继续运行。 若要停止这些线程，可以在异常处理程序中设置布尔变量，并在并行循环的每个迭代中检查其值。 如果值指示已引发异常，请使用 ParallelLoopState 变量停止或中断循环。

