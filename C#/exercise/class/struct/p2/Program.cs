// 重写 p1

struct Books
{
 private string title;
 private string author;
 private string subject;
 private int bookId;

 public void setValues(string t, string a, string s, int id)
 {
  title = t;
  author = a;
  subject = s;
  bookId = id;
 }

 public void display()
 {
  Console.WriteLine("Title : {0}", title);
  Console.WriteLine("Author : {0}", author);
  Console.WriteLine("Subject : {0}", subject);
  Console.WriteLine("BookId :{0}", bookId);
 }
};

public class testStructure
{
 public static void Main(string[] args)
 {
  Books Book1 = new Books(); /* 声明 Book1，类型为 Books */
  Books Book2 = new Books(); /* 声明 Book2，类型为 Books */

  /* book 1 */
  Book1.setValues("C Programming",
"Nuha Ali", "C Programming Tutorial", 6495407);

  /* book 2  */
  Book2.setValues("Telecom Billing",
"Zara Ali", "Telecom Billing Tutorial", 6495700);

  /* 打印 Book1 信息 */
  Book1.display();

  /* 打印 Book2 信息 */
  Book2.display();
  Console.ReadKey();
 }
}