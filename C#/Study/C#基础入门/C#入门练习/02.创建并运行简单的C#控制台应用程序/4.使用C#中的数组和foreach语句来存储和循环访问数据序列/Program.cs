string[] orderNum = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string num in orderNum)
{
 if (num.StartsWith("B"))
 {
  Console.WriteLine(num);
 }
}