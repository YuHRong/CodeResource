// Path类合并路径和获取文件信息的示例：
/*
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
*/


// Directory类创建目录、检查是否存在并枚举其文件：
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\ExampleDirectory";

        // Create a new directory
        Directory.CreateDirectory(directoryPath);

        // Check if the directory exists
        if (Directory.Exists(directoryPath))
        {
            Console.WriteLine("Directory exists.");

            // Enumerate files in the directory
            foreach (string file in Directory.EnumerateFiles(directoryPath))
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }
}
*/

// 使用 File类创建文件、向其写入文本以及读回文本：
/*
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

*/

// 以下示例演示如何创建目录、在该目录中创建文件、将文本写入文件以及读回文本：
/*
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
*/

// 下面示例演示如何使用  StreamWriter  类将数据写入 CSV 文件：
/*
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
*/

// 使用StreamReader
/*
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
*/

// 使用FileStream向文件写入数据的示例
/*
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
*/

// 使用FileStream从文件中读取数据
/*
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
*/

// 在文件中读取、写入和查找
/*
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
*/

// 使用 FileStream 属性实现访问文件控制
/*
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
*/

// 在文件操作中实现错误处理的示例
/*
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
*/

// 使用 BinaryReader 和 BinaryWriter
/*
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
*/

// 使用 BinaryReader 和 BinaryWriter 与编码
/*
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
*/

// 使用 BinaryReader 和 BinaryWriter 与 FileStream
/*
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
*/

