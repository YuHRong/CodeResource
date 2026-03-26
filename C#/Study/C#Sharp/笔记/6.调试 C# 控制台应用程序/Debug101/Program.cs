/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

/* string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage();
        messageText = messageText + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
 return "Hi, my name is Andrew. Good to meet you.";
}
 */


 /*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

void ChangeValue(int value) 
{
    value = 10;
}