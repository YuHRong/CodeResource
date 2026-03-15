using Files_M1;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main()
    {
        // 创建目录
        String directoryPath = @"C:\TempDir\SampleDirectory";

        // 创建两个子目录
        string subDirectoryPath1 = Path.Combine(directoryPath, "SubDirectory1");
        string subDirectoryPath2 = Path.Combine(directoryPath, "SubDirectory2");

        // 创建文件
        string filePath = Path.Combine(directoryPath, "sample.txt");
        string appendFilePath = Path.Combine(directoryPath, "append.txt");
        string copyFilePath = Path.Combine(directoryPath, "copy.txt");
        string moveFilePath = Path.Combine(directoryPath, "moved.txt");

        // 显示路径
        Console.WriteLine($"Directory path: {directoryPath}");
        Console.WriteLine($"Text file paths ... Sample file path: {filePath}, Append file path: {appendFilePath}, Copy file path: {copyFilePath}, Move file path: {moveFilePath}");

        // 检查 directoryPath目录是否存在,如果不存在择创建 directoryPath 目录
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine($"Created directory: {directoryPath}");
        }

        // 检查 subDirectoryPath1 目录是否真存在，不存在择创建此目录
        if (!Directory.Exists(subDirectoryPath1))
        {
            Directory.CreateDirectory(subDirectoryPath1);
            Console.WriteLine($"Created subdirectory: {subDirectoryPath1}");
        }

        // 检查 subDirectoryPath2 目录是否存在，若不存在择创建 subDirectoryPath2 目录
        if (!Directory.Exists(subDirectoryPath2))
        {
            Directory.CreateDirectory(subDirectoryPath2);
            Console.WriteLine($"Created subdirectory: {subDirectoryPath2}");
        }

        //使用File类在根目录中创建示例文件
        File.WriteAllText(filePath, "This is a ample file.");

        //使用File类在子目录中创建示例文件
        File.WriteAllText(Path.Combine(subDirectoryPath1, "file1.txt"), "Content of file1 in SubDirectory1");
        File.WriteAllText(Path.Combine(subDirectoryPath2, "file2.txt"), "Content of file2 in SubDirectory2");

        Console.WriteLine("\nEnumerating directories and files ...\n");

        // 枚举指定根目录的文件
        foreach (var file in Directory.GetFiles(directoryPath))
        {
            Console.WriteLine($"File: {file}");
        }

        // 枚举指定根目录的文件
        foreach (var file in Directory.GetFiles(directoryPath))
        {
            Console.WriteLine($"File: {file}");
        }

        // 枚举指定根目录中的目录
        foreach (var dir in Directory.GetDirectories(directoryPath))
        {
            Console.WriteLine($"File: {dir}");
        }

        //枚举指定根目录的每个子目录中的文件
        foreach (var subDir in Directory.GetDirectories(directoryPath))
        {
            foreach (var file in Directory.GetFiles(subDir))
            {
                Console.WriteLine($"File: {file}");
            }
        }

        /*         foreach (var entry in Directory.EnumerateFileSystemEntries(directoryPath, "*", SearchOption.AllDirect
                {
                    Console.WriteLine($"Entry: {entry}");
                }*/

        // 使用数值数组构建 CSV 格式的字符串
        Console.WriteLine("\nUse theFile class to write and read CSV-formatted text files."); ;

        string label = "deposits";
        double[,] depositValues =
        {
            {100.50, 200.75, 300.25},
{150.00, 250.50, 350.75 },
{175.25, 275.00, 375.75},
        };

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < depositValues.GetLength(0); i++)
        {
            sb.AppendLine($"{label}: {depositValues[i, 0]}, {depositValues[i, 1]}, {depositValues[i, 2]}");
        }

        //将StringBuilder对象的字符串表示形式拆分为字符串数组
        //根据环境的换行符，删除任何空条目。
        string csvString = sb.ToString();
        string[] csvLines = csvString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nCSV formatted string array:");
        foreach (var line in csvLines)
        {
            Console.WriteLine(line);
        }

        //将CSV格式的字符串数组写入文本文件。如果文件不存在，则创建该文件，如果存在，则覆盖该文件。
        File.WriteAllText(filePath, csvString);

        //将文本文件的内容读入字符串数组并显示文件内容
        string[] readLines = File.ReadAllLines(filePath);
        Console.WriteLine($"\nContent read from the {filePath} file:");
        foreach (var line in readLines)
        {
            Console.WriteLine(line);
        }

        // 在文本文件中添加新行
        File.AppendAllText(filePath, "deposits: 215.25, 417, 111.5\r\n");
        //读取并显示更新的文件内容
        string[] readUpdatedLines = File.ReadAllLines(filePath);
        Console.WriteLine($"\nContent read from updated the {filePath} file:");
        foreach (var line in readUpdatedLines)
        {
            Console.WriteLine(line);
        }

        //从CSV格式的字符串中提取标签和值分量
        string readLabel = readUpdatedLines[0].Split(':')[0];
        double[,] readDepositValues = new double[readUpdatedLines.Length, 3];
        for (int i = 0; i < readUpdatedLines.Length; i++)
        {
            string[] parts = readUpdatedLines[i].Split(':');
            string[] values = parts[1].Split(',');
            for (int j = 0; j < values.Length; j++)
            {
                readDepositValues[i, j] = double.Parse(values[j]);
            }
        }

        Console.WriteLine($"\nLabel: {readLabel}");
        Console.WriteLine("Deposit values:");
        for (int i = 0; i < readDepositValues.GetLength(0); i++)
        {
            Console.WriteLine($"{readDepositValues[i, 0]:C}, {readDepositValues[i, 1]:C}, {readDepositValues[i, 2]:C}");
        }


        Console.WriteLine("\nUse the File class to perform file management operations.\n");

        //检查append.txt文件是否存在
        if (File.Exists(appendFilePath))
        {
            Console.WriteLine($"The {appendFilePath} file exists.");
        }
        else
        {
            Console.WriteLine($"The {appendFilePath} file does not exist.");
        }

        //将sample.txt文件复制到copyFilePath变量定义的文件位置
        File.Copy(filePath, copyFilePath, true);
        Console.WriteLine($"Copied {filePath} to {copyFilePath}.");


        //将copy.txt文件移动到moveFilePath变量定义的文件位置
        File.Move(copyFilePath, moveFilePath, true);
        Console.WriteLine($"Moved {copyFilePath} to {moveFilePath}");

        // 删除 move.txt 文件
        if (File.Exists(moveFilePath))
        {
            File.Delete(moveFilePath);
            Console.WriteLine($"Deleted file: {moveFilePath}");
        }
    }
}
