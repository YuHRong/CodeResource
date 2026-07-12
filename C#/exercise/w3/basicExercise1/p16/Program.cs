// string char_str = "hello world!";
// Console.WriteLine(char_str[char_str.Length -2]);



// Displaying the result of rearranging the first and last characters of a string
// Rearranges the first and last characters of the string
Console.WriteLine(str_char("w3resource"));
Console.WriteLine(str_char("python"));

// Returns the same character for a single-character string
Console.WriteLine(str_char("x"));

static string str_char(string str)
{
 // Using the ternary operator to rearrange characters based on the length of the string
 return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
}