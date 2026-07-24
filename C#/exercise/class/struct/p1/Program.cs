struct Books
{
 public string title;
 public string author;
 public string subject;
 public int bookId;
};

public class testStructure
{
 public static void Main()
 {
  Books Book1;        /* 声明 Book1，类型为 Books */
  Books Book2;        /* 声明 Book2，类型为 Books */

  // book1
  Book1.title = "C Programming";
  Book1.author = "Nuha Ali";
  Book1.subject = "C Programming Tutorial";
  Book1.bookId = 6495407;

  // book2
  Book2.title = "Telecom Billing";
  Book2.author = "Zara Ali";
  Book2.subject = "Telecom Billing Tutorial";
  Book2.bookId = 6495700;

  // 打印 book1 信息
  Console.WriteLine($"Book 1 title : {Book1.title}");
  Console.WriteLine($"Book 1 author : {Book1.author}");
  Console.WriteLine($"Book 1 subject : {Book1.subject}");
  Console.WriteLine("Book 1 book_id :{0}", Book1.bookId);

  // book2 信息
  Console.WriteLine("Book 2 title : {0}", Book2.title);
  Console.WriteLine("Book 2 author : {0}", Book2.author);
  Console.WriteLine("Book 2 subject : {0}", Book2.subject);
  Console.WriteLine("Book 2 book_id : {0}", Book2.bookId);

  Console.ReadKey();
 }
}