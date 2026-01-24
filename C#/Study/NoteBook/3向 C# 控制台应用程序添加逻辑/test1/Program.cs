/*
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/

// 代码示例1
/*bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/

//代码示例2
/*int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/
/*
bool flag = true;
if (flag) Console.WriteLine(flag);
*/
/*
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");