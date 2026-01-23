/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "a123";
fraudulentOrderIDs[1] = "b456";
fraudulentOrderIDs[2] = "c789";
// fraudulentOrderIDs[3] = "d000";
*/

string[] fraudulentOrderIDs = ["a123", "b456", "c789"];

Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
Console.WriteLine($"second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "f000";

Console.WriteLine($"reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
