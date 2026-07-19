using static System.Console;

var list1 = new LinkedList();
list1.AddLast(2);
list1.AddLast(4);
list1.AddLast("6");


 foreach (int i in list1)
{
 WriteLine(i);
}