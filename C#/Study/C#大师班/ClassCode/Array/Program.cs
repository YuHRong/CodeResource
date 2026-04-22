//string[] firstName = new string[5];
//firstName[0] = "tim";
//firstName[1] = "Jim";
//firstName[2] = "Bob";
//firstName[4] = "Tom";

//Console.WriteLine($"\nHis Name is {firstName[0]}");

//foreach(string name in firstName)
//Console.WriteLine(name);

string data = "tim, jim, Bob, Amma, Duo";
string[] firstNames = data.Split(separator: ',');
Console.WriteLine(firstNames.Length);
