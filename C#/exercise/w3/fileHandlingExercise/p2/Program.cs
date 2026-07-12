// Write a program in C# Sharp to remove a file from the disk.

// 申明文件名字符串变量
string fileName = $"mytest.txt";

// 像控制台打印消息
Console.WriteLine("Remove a file from the disk (at first create the file ) : ");
Console.WriteLine("--------------------------------------------------------------");

// 检查文件
if (File.Exists(fileName))
{
 // 如果文件存在，删除文件
 File.Delete(fileName);
 Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName); // Displaying a message indicating successful file deletion
}
else
{
 // 如果文件不存在，显示提示消息
 Console.WriteLine(" File does not exist");

 // 回车退出
 Console.ReadLine();
}