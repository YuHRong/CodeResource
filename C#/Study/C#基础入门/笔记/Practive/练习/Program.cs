/*
int[] asciiCodes = { 72, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };
foreach (int code in asciiCodes)
{
    Console.Write((char)code);
}
*/
/*
string first = "Hello";
string second = "world";
Console.WriteLine(first + " " + second +"!");
*/
/*
Hello();
void Hello()
{
    Console.Write("Hello");
    Console.Write(" ");
    Console.Write("world");
    Console.Write("!");
}
*/
/*
int[] asciiCodes = { 72, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };
System.Text.StringBuilder result = new();

for (int i = 0; i < asciiCodes.Length; i++)
{
    result.Append((char)asciiCodes[i]);

    if (i >= asciiCodes.Length - 1)
    {
        Console.WriteLine(result.ToString());
    }
}
*/
/*
int[] asciiCodes = { 72, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };
string output = "";
int index = 0;

while (index < asciiCodes.Length)
{
    output += (char)asciiCodes[index];
    index++;

    if (index == asciiCodes.Length)
    {
        Console.WriteLine(output);
    }
}
*/
/*
int[] asciiCodes = { 72, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };
var message = new System.Text.StringBuilder();

for (int i = 0; i < asciiCodes.Length; i++)
{
    message.Append((char)asciiCodes[i]);

    if (i == 11)
    {
        Console.WriteLine(message);
    }
}
*/

int[] asciiCodes = { 72, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };
string text = "";
int position = 0;

do
{
    text += (char)asciiCodes[position];
    position++;

    if (position == asciiCodes.Length)
    {
        Console.WriteLine(text);
    }
}
while (position < asciiCodes.Length);   