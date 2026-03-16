using Files_M1;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main()
    {
        /*
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

             foreach (var entry in Directory.EnumerateFileSystemEntries(directoryPath, "*", SearchOption.AllDirect
                {
                    Console.WriteLine($"Entry: {entry}");
                }

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
        */

        Console.WriteLine("\nUse the StreamWriter and StreamReader classes.\n");

        //获取可执行程序的当前目录
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine($"Current Directory: {currentDirectory}");

        //使用currentDirectory创建名为TransactionLogs的目录路径
        string transactionsDirectoryPath = Path.Combine(currentDirectory, "TransactionLogs");
        if (!Directory.Exists(transactionsDirectoryPath))
        {
            Directory.CreateDirectory(transactionsDirectoryPath);
            Console.WriteLine($"Created directory: {transactionsDirectoryPath}");
        }

        //在TransactionLogs目录中为名为transaction.csv的文件创建一个文件路径
        string csvFilePath = Path.Combine(transactionsDirectoryPath, "transactions.csv");


        // Simulate one month of transactions for customer Niki Demetriou
        string firstName = "Niki";
        string lastName = "Demetriou";
        BankCustomer customer = new BankCustomer(firstName, lastName);

        // Add CheckingAccount, SavingsAccount, and MoneyMarketAccount to the customer object using the customer.CustomerId
        customer.AddAccount(new CheckingAccount(customer, customer.CustomerId, 5000));
        customer.AddAccount(new SavingsAccount(customer, customer.CustomerId, 15000));
        customer.AddAccount(new MoneyMarketAccount(customer, customer.CustomerId, 90000));

        DateOnly startDate = new DateOnly(2025, 3, 1);
        DateOnly endDate = new DateOnly(2025, 3, 31);
        customer = SimulateDepositsWithdrawalsTransfers.SimulateActivityDateRange(startDate, endDate, customer);


        using (StreamWriter sw = new StreamWriter(csvFilePath))
        {
            sw.WriteLine("TransactionId,TransactionType,TransactionDate,TransactionTime,PriorBalance,TransactionAmount,SourceAccountNumber,TargetAccountNumber,Description");

            Console.WriteLine("\nSimulated transactions:\n");
            foreach (var account in customer.Accounts)
            {
                foreach (var transaction in account.Transactions)
                {
                    Console.WriteLine($"{transaction.TransactionId},{transaction.TransactionType},{transaction.TransactionDate},{transaction.TransactionTime},{transaction.PriorBalance:F2},{transaction.TransactionAmount:F2},{transaction.SourceAccountNumber},{transaction.TargetAccountNumber},{transaction.Description}");
                    sw.WriteLine($"{transaction.TransactionId},{transaction.TransactionType},{transaction.TransactionDate},{transaction.TransactionTime},{transaction.PriorBalance:F2},{transaction.TransactionAmount:F2},{transaction.SourceAccountNumber},{transaction.TargetAccountNumber},{transaction.Description}");
                }
            }
        }


        // Read the transaction data from the transactions.csv file
        using (StreamReader sr = new StreamReader(csvFilePath))
        {
            string headerLine = sr.ReadLine(); // Read the header line
            Console.WriteLine("\nTransaction data read from the CSV file:\n");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // Use the FileStream class to perform low-level file I/O operations

        // Create a filepath for the filestream.txt file
        string fileStreamPath = Path.Combine(currentDirectory, "filestream.txt");

        // Prepare transaction data from customer accounts
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("TransactionId,TransactionType,TransactionDate,TransactionTime,PriorBalance,TransactionAmount,SourceAccountNumber,TargetAccountNumber,Description"); ;

        foreach (var account in customer.Accounts)
        {
            foreach (var transaction in account.Transactions)
            {
                // Append transaction data to the StringBuilder object
                sb.AppendLine($"{transaction.TransactionId},{transaction.TransactionType},{transaction.TransactionDate},{transaction.TransactionTime},{transaction.PriorBalance:F2},{transaction.TransactionAmount:f2},{transaction.SourceAccountNumber},{transaction.TargetAccountNumber},{transaction.Description}");
            }
        }

        Console.WriteLine($"\n\nUse the FileStream class to perform file I/O operations.");

        //使用FileStream将事务数据写入文件
        using (FileStream fileStream = new FileStream(fileStreamPath, FileMode.Create, FileAccess.Write))
        {
            // Convert the StringBuilder object to a byte array and write the byte array to the file
            byte[] transactionDataBytes = new UTF8Encoding(true).GetBytes(sb.ToString());

            // Use the Write method to write the byte array to the file
            fileStream.Write(transactionDataBytes, 0, transactionDataBytes.Length);
            Console.WriteLine($"\nFile length after write: {fileStream.Length} bytes");

            // Use the Flush method to ensure all data is written to the file
            fileStream.Flush();
        }

        Console.WriteLine($"\nTransaction data written using FileStream. File: {fileStreamPath}");

        using (FileStream fileStream = new FileStream(fileStreamPath, FileMode.Open, FileAccess.Read))
        {
            byte[] readBuffer = new byte[1024];
            UTF8Encoding utf8Decoder = new UTF8Encoding(true);
            int bytesRead;

            Console.WriteLine("\nUsing FileStream to read/display transaction data.\n");

            while ((bytesRead = fileStream.Read(readBuffer, 0, readBuffer.Length)) > 0)
            {
                Console.WriteLine($"bytes read: {utf8Decoder.GetString(readBuffer, 0, bytesRead)}\n");
            }


            Console.WriteLine($"File length: {fileStream.Length} bytes");
            Console.WriteLine($"Current position: {fileStream.Position} bytes");

            // Use the Seek method to move to the beginning of the file
            fileStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine($"Position after seek: {fileStream.Position} bytes");

            // Use the FileStream.Read method to read the first 100 bytes
            bytesRead = fileStream.Read(readBuffer, 0, 100);
            Console.WriteLine($"Read first 100 bytes: {utf8Decoder.GetString(readBuffer, 0, bytesRead)}");

        }

        // Create a filepath for a binary file named binary.dat
        string binaryFilePath = Path.Combine(currentDirectory, "binary.dat");

        // Create a BinaryWriter object and write binary data to the binary.dat file
        using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create)))
        {
            binaryWriter.Write(1.25);
            binaryWriter.Write("Hello");
            binaryWriter.Write(true);
        }

        Console.WriteLine($"\n\nBinary data written to: {binaryFilePath}");

        // Create a BinaryReader object and read binary data from the binary.dat file
        using (BinaryReader binaryReader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open)))
        {
            double a = binaryReader.ReadDouble();
            string b = binaryReader.ReadString();
            bool c = binaryReader.ReadBoolean();
            Console.WriteLine($"Binary data read from {binaryFilePath}: {a}, {b}, {c}");
        }
    }
}
