#include <iostream>
#include <string>
using namespace std;

int main() {
	string rawData;
	cout << "请输入rawData的值: ";
	getline(cin, rawData);

	// 这里处理你的逻辑，使用rawData变量
	cout << "您输入的rawData是: " << rawData << endl;

	system("pause"); // 防止窗口立即关闭
	return 0;
}
C#版本代码：
using System;

class Program
{
	static void Main()
	{
		Console.Write("请输入rawData的值: ");
		string rawData = Console.ReadLine();

		// 这里处理你的逻辑，使用rawData变量
		Console.WriteLine($"您输入的rawData是: {rawData}");
		Console.ReadKey(); // 防止窗口立即关闭
	}
}