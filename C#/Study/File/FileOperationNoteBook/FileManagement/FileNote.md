# 文件操作笔记

在 C# 中，文件 I/O是`System.IO`命名空间中的各种类。 这些类提供用于处理目录、路径和文件的属性和方法，以及以不同的格式读取和写入数据。 了解如何有效地使用这些`System.IO`类是实现 C# 应用程序中文件存储解决方案的关键。

## 查看常见文件 I/O操作

开发人员使用文件 I/O操作以多种方式管理应用数据。 例如，应用程序可以执行以下操作：

- 保留数据：在本地存储数据，以确保在应用程序会话之间保留数据。
- 交换数据：使用 CSV 和 JSON 等常见文件格式促进不同应用程序或系统之间的数据交换。
- 备份和还原：实现备份和还原功能来保护重要数据。
- 分析数据：通过读取和处理存储在文件中的大型数据集来执行数据分析或报告。

## 结构化和非结构化存储类型

数据可分为两种主要类型：结构化和非结构化。 了解这些类型之间的差异对于有效的数据管理和存储非常重要。
- 结构化存储：结构化存储是指以预定义方式组织的数据，通常以行和列为单位。 这种类型的存储是高度有序的，遵循特定的架构，因此可以轻松查询和分析。 结构化存储的最常见示例是关系数据库。 结构化数据的另一个示例是用于存储结构化文本文件的逗号分隔值（CSV）格式。
- 非结构化存储：非结构化存储是指不遵循预定义架构或结构的数据。 这种类型的存储更加灵活，可以容纳各种类型的数据，例如文本、图像和视频。 非结构化存储的最常见示例是文件系统，其中文件可以采用任何格式存储，而无需特定组织。 非结构化数据通常以 JSON、XML 或纯文本文件等格式存储。 例如，包含具有不同属性的用户配置文件的 JSON 文件被视为非结构化数据。 结构不足使得非结构化数据对分析和处理更具挑战性。 JSON 格式通常用于应用程序之间的数据交换，使其成为非结构化数据存储的热门选择。

可以使用结构化和非结构化格式之间的混合存储数据。 半结构化数据包含一些组织属性，但不符合严格的架构。

## 常见文件格式

文本文件格式通常用于存储和交换数据。 它们是人工可读的，使用各种编程语言轻松创建、修改和处理。 一些常见的文本文件格式包括：

- 文本文件（TXT）。
TXT 文件是包含未格式化文本的标准文本文档。 它是存储纯文本数据的最简单、最广泛使用的文件格式之一。

- 逗号分隔值 (CSV)。
CSV 文件用于以纯文本形式存储表格数据。 文件中的每一行都表示表中的一行，列用逗号分隔。 CSV 文件通常用于应用程序之间的数据交换。

- JavaScript 对象表示法（JSON）。
JSON 是一种轻量级数据交换格式，便于用户读取和写入，并且易于计算机分析和生成。 JSON 通常用于在 Web 应用程序中传输数据。

- eXtensible 标记语言 （XML）。
XML 是一种标记语言，它定义一组规则，用于以可读和计算机可读的格式对文档进行编码。 它通常用于数据交换和配置文件。

## System.IO 中常用的I/O类

`System.IO`命名空间为文件 I/O作提供了一组丰富的类。 下面是一些常用的类：

| 类名          | 说明                                                                                                                          |
| ------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| File          | `File`类提供用于创建、复制、删除、移动和打开文件的静态方法，以及从文件读取和写入文件。 它非常适合快速简单的文件操作。         |
| Directory     | `Directory`类提供用于创建、移动和枚举目录和子目录的静态方法。 它可用于管理目录及其内容。                                      |
| Path          | `Path`类对路径字符串执行操作，例如组合、分析和检索目录和文件名。 它可用于操作文件和目录路径。                                 |
| StreamReader  | `StreamReader`类专为读取文本文件而设计。 它提供按行读取文本数据的方法，从而方便处理文本文件。                                 |
| StreamWriter  | 类专为编写文本文件而设计。 它提供了用于编写文本数据的方法，使创建和修改文本文件变得容易。                                     |
| FileStream    | `FileStream`类提供用于从文件读取和写入文件的流。 它提供对文件操作的更多控制，例如读取和写入字节、处理大型文件和执行异步操作。 |
| BinaryReader  | `BinaryReader`将基元数据类型读取为特定编码中的二进制值。 它可用于读取二进制文件。                                             |
| BinaryWriter  | `BinaryWriter`将二进制文件中的基元类型写入流，并支持在特定编码中编写字符串。 它可用于编写二进制文件。                         |
| DirectoryInfo | `DirectoryInfo`类提供用于创建、移动和枚举目录和子目录的实例方法。 与`Directory`类相比，它提供更详细的信息和控件。             |
| FileInfo      | `FileInfo`类提供用于创建、复制、删除、移动和打开文件的实例方法。 与`File`类相比，它提供更详细的信息和控件。                   |

## Path 类

.NET 中的`Path`类用于处理文件和目录路径。 它提供检索和修改路径信息的方法。

### Path 类中常用的方法

| 方法名                        | 说明                                 |
| ----------------------------- | ------------------------------------ |
| Combine()                     | (用于将多个字符串合并到单个路径中。  |
| GetDirectoryName()            | 用于从路径获取目录信息。             |
| GetFileName()                 | 用于从路径获取文件名和扩展名。       |
| GetFileNameWithoutExtension() | 用于获取没有扩展名的文件名。         |
| GetExtension()                | 用于获取文件的扩展名。               |
| GetFullPath()                 | 用于获取文件的完全限定路径。         |
| GetTempPath()                 | 用于获取当前系统的临时文件夹的路径。 |
| GetTempFileName()             | 用于创建临时文件并返回其路径。       |

Path类合并路径和获取文件信息的示例：

    using System;
    using System.IO;
    class Program
    {
     static void Main()
     {
      string directoryPath = @"C:\ExampleDirectory";
      string fileName = "example.txt";

      // Combine directory and file name to create a full path
      string fullPath = Path.Combine(directoryPath, fileName);
      Console.WriteLine("Full Path: " + fullPath);

      // Get the file name without extension
      string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
      Console.WriteLine("File Name Without Extension: " + fileNameWithoutExtension);

      // Get the file extension
      string fileExtension = Path.GetExtension(fullPath);
      Console.WriteLine("File Extension: " + fileExtension);
     }
    }

## Directory 类

.NET 中的`Directory`类提供用于创建、删除、移动和枚举目录的方法。 这些方法可用于管理应用程序中的目录。

### Directory 类中常用的方法

| 方法名                 | 说明                               |
| ---------------------- | ---------------------------------- |
| Exists()               | `Exists()`用于检查目录是否存在。   |
| CreateDirectory()      | 用于创建新目录。                   |
| GetCurrentDirectory()  | 用于获取当前工作目录。             |
| GetFiles()             | 用于获取指定目录中的文件名数组。   |
| Delete()               | 用于删除现有目录。                 |
| Move()                 | 用于移动或重命名目录。             |
| EnumerateDirectories() | 用于列出指定路径中的所有目录。     |
| EnumerateFiles()       | 用于列出指定路径中的所有文件。     |
| GetDirectories()       | 用于获取指定目录中的目录名称数组。 |
| GetParent()            | 用于获取指定路径的父目录。         |

以下示例演示如何使用该`Directory`类创建目录、检查是否存在并枚举其文件：

    using System;
    using System.IO;
    class Program
    {
     static void Main()
     {
      string directoryPath = @"C:\ExampleDirectory";
      string fileName = "example.txt";

      // Combine directory and file name to create a full path
      string fullPath = Path.Combine(directoryPath, fileName);
      Console.WriteLine("Full Path: " + fullPath);

      // Get the file name without extension
      string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
      Console.WriteLine("File Name Without Extension: " + fileNameWithoutExtension);

      // Get the file extension
      string fileExtension = Path.GetExtension(fullPath);
      Console.WriteLine("File Extension: " + fileExtension);
     }
    }

## File 类

.NET 中的 File 类提供了执行各种文件操作的方法，例如读取、写入、复制和删除文件。

### File 中常用的方法

| 方法名          | 说明                                     |
| --------------- | ---------------------------------------- |
| Exists()        | 用于检查文件是否存在。                   |
| Create()        | 用于创建新文件。                         |
| Delete()        | 用于删除文件。                           |
| Copy()          | 用于将文件复制到新位置。                 |
| Move()          | 用于移动或重命名文件。                   |
| ReadAllText()   | 用于从文件读取所有文本。                 |
| WriteAllText()  | 用于将文本写入文件。                     |
| AppendText()    | 用于向文件追加文本。                     |
| ReadAllLines()  | 用于将文件中的所有行读取到字符串数组中。 |
| WriteAllLines() | 用于将字符串数组写入文件。               |
| ReadAllBytes()  | 用于将文件中的所有字节读取到字节数组中。 |
| WriteAllBytes() | 用于将字节数组写入文件。                 |
| Open()          | 用于打开文件进行读取或写入。             |
| OpenRead()      | 用于打开要读取的文件。                   |
| OpenWrite       | 用于打开文件进行写入。                   |
| OpenText()      | 用于打开用于读取文本的文件。             |
| GetAttributes() | 用于获取文件的属性。                     |
| SetAttributes() | 用于设置文件的属性。                     |

以下示例演示如何使用`File`类创建文件、向其写入文本以及读回文本：

    using System;
    using System.IO;
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\ExampleFile.txt";

            // Create a new file and write text to it
            File.WriteAllText(filePath, "Hello, World!");

            // Read the text from the file
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
    }

## 结合使用 Directory、File 和 Path 类 

应用程序通常需要结合文件和目录操作。 这些`Directory`、`File`和`Path`类可以一起使用，来执行复杂的文件 I/O操作。

以下示例演示如何创建目录、在该目录中创建文件、将文本写入文件以及读回文本：

    using System;
    using System.IO;
    class Program
    {
        static void Main()
        {
            string directoryPath = @"C:\ExampleDirectory";
            string fileName = "example.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            // Create a new directory
            Directory.CreateDirectory(directoryPath);

            // Create a new file and write text to it
            File.WriteAllText(filePath, "Hello, World!");

            // Read the text from the file
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
    }

## StreamReader 和 StreamWriter 类

在 `System.IO`命名空间中，`StreamReader`和`StreamWriter`是常用于读取和写入文本文件的类，
`StreamReader`类用于从特定编码中的字节流读取字符，而`StreamWriter`类用于将字符写入特定编码中的流。 这些`StreamReader`和`StreamWriter`类可用于处理文本文件，例如逗号分隔值（CSV）文件，其中数据按行和列进行组织。

### 什么是流

在 .NET 中，流用于表示可从中读取或写入的字节序列。 流提供了一种以灵活、高效的方式处理数据的方法，允许以各种格式（包括文本、二进制和网络流）读取和写入数据。`Stream`类是 .NET 中所有流的基类，它提供读取和写入数据的方法，以及查找流中特定位置的方法。`Stream`类是抽象类，这意味着无法直接实例化。 而是使用派生类（例如`FileStream`,`MemoryStream`,`NetworkStream`和其他类）来处理特定类型的数据源。

这些`StreamReader`和`StreamWriter`类基于`Stream`类构建，提供用于读取和写入文本数据的其他功能。

### 使用 StreamReader 和 StreamWriter 类写入和读取文本文件

`StreamReader`和`StreamWriter`类旨在处理文本数据，该数据通常表示为字符序列。 它们处理字符的编码和解码，允许你处理各种格式的文本文件，包括 UTF-8、ASCII 和 Unicode。
注意`StreamReader`和`StreamWriter`类实现`IDisposable`接口，这意味着它们应在`using`语句中使用，以确保在操作完成后正确释放资源。

#### 使用 StreamWriter 编写文本文件

`StreamWriter`类用于提供将字符写入特定编码中的流。 它提供按行或字符逐个字符写入文本文件的方法。`StreamWriter`类可用于编写大型文件，因为它允许以内存高效的方式写入数据。

`StreamWriter`类包括的方法

| 方法名      | 说明                                                                      |
| ----------- | ------------------------------------------------------------------------- |
| Write()     | 将指定的字符串写入当前流。                                     |
| WriteLine() | 将指定的字符串后跟行终止符写入当前流。                     |
| Flush()     | 清除当前编写器的所有缓冲区，并导致任何缓冲数据写入基础设备。   |
| Close()     | 以确保文件已正确关闭并释放资源。 也可以直接调用`Dispose()` |

使用 `StreamWriter` 类将数据写入 CSV 文件示例：

    using System;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string filePath = "data.csv";

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write some data
                writer.WriteLine("Name,Age,Occupation");
                writer.WriteLine("Elize Harmsen,30,Engineer");
                writer.WriteLine("Peter Zammit,25,Designer");
                writer.WriteLine("Niki Demetriou,35,Manager");
            }

            Console.WriteLine($"CSV file created at: {filePath}");
        }
    }

#### 使用 StreamReader 读取文本文件

`StreamReader`类用于从特定编码中的字节流读取字符。 它提供按行或字符逐个字符读取文本文件的方法。 该`StreamReader`类可用于读取大型文件，因为它允许以内存高效的方式读取数据。

`StreamReader`类包括的方法

| 方法名      | 说明                                                                |
| ----------- | ------------------------------------------------------------------- |
| Read()      | 从输入流中读取下一个字符，并将读取器的位置提升一个字符。    |
| ReadLine()  | 从当前流中读取一行字符，并将其作为字符串返回。          |
| ReadToEnd() | 从当前位置读取流末尾的所有字符，并将其作为字符串返回。 |
| Peek()      | 返回下一个可用字符，而不移动读取器的位置。                  |

使用 `StreamReader`类逐行读取 CSV 文件：示例: 

    using System;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string filePath = "data.csv";

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    Console.WriteLine(line);

                }
            }
        }
    }

## 使用 FileStream 类控制文件访问

`FileStream`类让你能够比`StreamReader`和`StreamWriter`等高级抽象以更细粒度的方式处理文件。
要创建一个`FileStream`对象，通常需要指定文件路径、打开文件的模式（例如`FileMode.Open`、`FileMode.Create`）以及访问级别（例如`FileAccess.Read`、`FileAccess.Write`

### FileStream 类中的关键属性

| 名称     | 说明                                                                  |
| -------- | --------------------------------------------------------------------- |
| Length   | 获取流中字节的长度。                                                  |
| Position | 获取或设置流中的当前位置。                                            |
| CanRead  | 指示流是否支持读取。如果流可以读取，此属性返回`true，否则返回`false`  |
| CanWrite | 指示流是否支持写入。如果流可以写入，此属性返回`true`，否则返回`false` |
| CanSeek  | 指示流是否支持查找。如果流支持查找，此属性返回`true`，否则返回`false` |

注意:
磁盘文件始终支持随机访问。`CanSeek`属性值根据底层文件类型设置为`true`或`false`

### FileStream 中的关键方法

| 名称    | 说明                                                                                       | 示例                              | 说明                         |
| ------- | ------------------------------------------------------------------------------------------ | --------------------------------- | ---------------------------- |
| Read    | 从流中读取一块字节并将数据写入缓冲区。                                                     | fs.Read(buffer, 0, buffer.Length) | 将数据读入缓冲区。           |
| Write   | 使用缓冲区中的数据将一块字节写入流。                                                       | fs.Write(data, 0, data.Length)    | 将数据数组中的数据写入文件。 |
| Seek    | 设置当前流中的位置。例如。                                                                 | fs.Seek(0, SeekOrigin.Begin)      | 将位置移动到文件的开头。     |
| Flush   | 清除当前流的全部缓冲区，并导致所有缓冲数据被写入文件。                                     |
| Close   | 关闭当前流并释放与之关联的任何资源。                                                       |
| Dispose | 释放`FileStream`对象使用的资源。当`FileStream`对象被直接或间接释放时，此方法会自动被调用。 |

## 使用 FileStream 类检查文件读写操作

你可以使用 `Read`、`Write`、`CopyTo` 和 `Flush` 等方法执行同步操作。
对于资源密集型的文件操作，使用 `ReadAsync`、`WriteAsync`、`CopyToAsync` 和 `FlushAsync`  等异步方法以避免阻塞主线程。

对于简单的文件操作，使用同步方法。对于性能关键的应用，使用异步方法。

### 使用`FileStream`向文件写入数据

    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string path = "example.txt";
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
            }

            Console.WriteLine("Data written to file.");
        }
    }

在这个示例中，创建一个`FileStream`对象来向名为 "`example.txt`" 的文件写入数据。
`FileMode.OpenOrCreate`选项会在文件存在时打开文件，如果不存在则创建新文件。
`FileAccess.Write`选项指定我们要向文件写入数据。然后使用
`Write`方法将字节数组写入文件。

### 使用`FileStream`从文件中读取数据

    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string path = "example.txt";
            byte[] buffer = new byte[1024]; // Adjust buffer size as needed

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Data read from file: " + readData);
            }
        }
    }

在这个示例中，创建一个`FileStream`对象来从文件 "`example.txt`" 中读取数据。
`FileMode.Open`选项用于打开文件进行读取，
`FileAccess.Read`选项指定我们想要从文件中读取。
然后使用`Read`方法将数据读取到缓冲区中，随后将缓冲区转换回字符串。

### 在文件中读取、写入和查找

    using System;
    using System.IO;
    using System.Threading.Tasks;

    class Program
    {
        static Task Main()
        {
            string path = "example.txt";
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

            // Writing to the file
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }

            // Reading from the file
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[data.Length];
                fs.Seek(0, SeekOrigin.Begin);
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Data read from file: " + readData);
            }
        }
    }

在这个示例中，我们使用 `FileStream` 将数据写入文件，然后读取数据。
然后演示`Seek`方法在文件中移动位置。

## 使用 FileStream 属性实现文件访问控制

`FileStream`类提供了用于控制文件访问的附加属性。

这些属性包括：

| 名称        | 说明                                                                                                       |
| ----------- | ---------------------------------------------------------------------------------------------------------- |
| CanRead     | 指示流是否支持读取。如果流可以读取，此属性返回`true`，否则返回`false`                                      |
| CanWrite    | 指示流是否支持写入。如果流可以写入，此属性返回`true`，否则返回`false`                                      |
| CanSeek     | 指示流是否支持查找。此属性在流支持查找时返回`true`，否则返回`false`                                        |
| FileAccess  | 指定文件的访问级别。可以设置为`Read`、`Write`或`ReadWrite`                                                 |
| FileShare   | 指定其他线程对文件的访问级别。可以设置为`None`、`Read`、`Write`或`ReadWrite`。                             |
| FileMode    | 指定操作系统如何打开文件。可以设置为`Append`、`Create`、`CreateNew`、`Open`、`OpenOrCreate`或`Truncate`。  |
| FileOptions | 指定打开文件时的选项。可以设置为`None`、`Asynchronous`、`SequentialScan`、`RandomAccess`或`WriteThrough`。 |

### 使用 FileStream 属性实现访问控制

    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string path = "example.txt";
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

            // Writing to the file
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 4096, false))
            {
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }

            // Reading from the file
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 4096, false))
            {
                byte[] buffer = new byte[data.Length];
                fs.Seek(0, SeekOrigin.Begin);
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Data read from file: " + readData);
            }
        }
    }

这段代码展示了如何使`FileStream`属性来控制文件访问。当写入文件时，`FileAccess`属性被设置为`Write`；当读取文件时，`FileAccess`属性被设置为`Read`。
`FileShare`属性被设置为`None`，这意味着在文件被使用时，其他线程无法访问该文件。

## 演示文件操作中的错误处理

`FileStream`类对访问缓存缓冲区的方法进行检查，以确保操作系统的句柄位置与`FileStream`对象使用的缓存位置相匹配。

如果检测到句柄位置出现意外变化：在`Read`操作期间，将丢弃缓冲区内容，并重新从文件中读取流。在执行`Write`操作时，缓冲区内容将被丢弃，并抛出`IOException`异常。

`注意`当访问或通过构造函数传递`SafeFileHandle`属性时，`FileStream`对象不会对其句柄拥有独占控制权。

### 在文件操作中实现错误处理的示例

    using System;
    using System.IO;
    using System.Threading.Tasks;
    class Program
    {
        static Task Main()
        {
            string path = "example.txt";
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

            try
            {
                // Writing to the file
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }

                // Reading from the file
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[data.Length];
                    fs.Seek(0, SeekOrigin.Begin);
                    int bytesRead = fs.Read(buffer, 0, buffer.Length);
            string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Data read from file: " + readData);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

在这个示例中，我们使用 `try`/`catch`块来处理文件操作过程中可能出现的 `IOException` 异常。



## BinaryReader 和 BinaryWriter

二进制文件是包含人类可读格式的数据的文件。

它们通常用于存储复杂数据结构、图像、音频、视频以及其他类型的内容。

与文本文件相比，二进制文件在存储和性能方面可能更高效，尤其是在处理大量数据时。

二进制文件通常不打算由人类打开和读取，因为它们可能包含特定于特定应用程序或系统的格式的数据。

`BinaryReader`和`BinaryWriter`类是 .NET 的`System.IO`命名空间的一部分，用于读取和写入二进制数据。

## BinaryReader和BinaryWriter的使用

尽管使用 `StreamReader` 和 `StreamWriter`足以处理文件操作。但在某些情况下需要使用 `BinaryReader` 和 `BinaryWriter`。
使用二进制存储的情况。

| 使用场景   | 说明                                                                                                                               | 使用示例                                                                                                                                                 |
| ---------- | ---------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 配置文件   | 某些应用程序使用二进制配置文件来存储设置和首选项。你可能需要读取或写入这些文件来管理应用程序配置。                                 | 你可能使用`BinaryWriter`将应用程序设置保存到二进制文件中，并使用`BinaryReader`在应用程序启动时加载这些设置。                                             |
| 数据序列化 | 二进制文件通常用于数据序列化，其中复杂的数据结构被转换为二进制格式进行存储或传输。这对于保存游戏数据、设置或其他结构化数据很有用。 | 保存游戏数据：在开发游戏时，你可能使用`BinaryWriter`将游戏状态（例如，玩家进度、得分）保存到二进制文件中，并使用`BinaryReader`在游戏启动时加载游戏状态。 |
| 多媒体存储 | 二进制文件用于存储图像、音频和视频等多媒体内容。在处理应用程序中的媒体文件时，你可能会使用二进制文件。                             | 处理媒体文件：你可能使用`BinaryReader`读取图像或音频文件，并使用`BinaryWriter`保存编辑后的媒体文件。                                                     |
| 网络通信   | 二进制文件在网络通信中用于高效传输数据。在处理涉及通过网络发送或接收数据的项目时，你可能会遇到二进制文件。                         |
| 文件压缩   | 二进制文件用于文件压缩，其中数据被压缩成二进制格式以节省空间。在项目中，你可能需要处理压缩文件。                                   |

### 使用 BinaryReader 和 BinaryWriter

示例: 

    using System;
    using System.IO;
    using System.Text;

    public class BinaryReaderWriterExample
    {
        public static void Main()
        {
            // Create a file to write to
            using (FileStream fs = new FileStream("example.dat", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Write some data
                    writer.Write(42); // Integer
                    writer.Write(3.14); // Double
                    writer.Write("Hello, World!"); // String
                }
            }

            // Read the data back
            using (FileStream fs = new FileStream("example.dat", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();

                    Console.WriteLine($"Integer: {intValue}");
                    Console.WriteLine($"Double: {doubleValue}");
                    Console.WriteLine($"String: {stringValue}");
                }
            }
        }
    }

在这个示例中，我们创建一个名为`example.dat`的二进制文件，并使用`BinaryWriter`将一个整数、一个双精度浮点数和一个字符串写入其中。然后，使用`BinaryReader` 读取这些数据并打印到控制台。

### 使用 BinaryReader 和 BinaryWriter 与编码

示例: 

    using System;
    using System.IO;
    using System.Text;

    public class BinaryReaderWriterEncodingExample
    {
        public static void Main()
        {
            // Create a file to write to
            using (FileStream fs = new FileStream("example.dat", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
                {
                    // Write some data with UTF-8 encoding
                    writer.Write(42); // Integer
                    writer.Write(3.14); // Double
                    writer.Write("Hello, World!"); // String
                }
            }

            // Read the data back
            using (FileStream fs = new FileStream("example.dat", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();

                    Console.WriteLine($"Integer: {intValue}");
                    Console.WriteLine($"Double: {doubleValue}");
                    Console.WriteLine($"String: {stringValue}");
                }
            }
        }
    }

在这个示例中，我们创建了一个名为`example.dat`的二进制文件，并使用`BinaryWriter`以 UTF-8 编码向其中写入一个整数、一个双精度浮点数和一个字符串。然后，使用`BinaryReader`以相同的编码读取这些数据，并将其打印到控制台。

### 使用 BinaryReader 和 BinaryWriter 与 FileStream

示例

    using System;
    using System.IO;
    using System.Text;

    public class BinaryReaderWriterFileStreamExample
    {
        public static void Main()
        {
            // Create a file to write to
            using (FileStream fs = new FileStream("example.dat", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Write some data
                    writer.Write(42); // Integer
                    writer.Write(3.14); // Double
                    writer.Write("Hello, World!"); // String
                }
            }

            // Read the data back
            using (FileStream fs = new FileStream("example.dat", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();

                    Console.WriteLine($"Integer: {intValue}");
                    Console.WriteLine($"Double: {doubleValue}");
                    Console.WriteLine($"String: {stringValue}");
                }
            }
        }
    }

在这个示例中，我们创建了一个名为`example.dat`的二进制文件，并使用`BinaryWriter`以`FileStream`的方式向其中写入一个整数、一个双精度浮点数和一个字符串。然后，使用`BinaryReader`以相同的  FileStream   方式读取这些数据，并将其打印到控制台。

