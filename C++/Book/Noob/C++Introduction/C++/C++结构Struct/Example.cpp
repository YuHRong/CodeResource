/* #include <iostream>
#include <cstring>

using namespace std;

// 申明结构体类型 Boks
struct Books
{
 char title[50];
 char author[50];
 char subject[100];
 int bookId;
};

int main()
{
 Books book1; // 定义结构体类型 Books 类型变量 book1
 Books book2; // 定义结构体类型 Books 的变量 Book2

 // Book1 详述
 strcpy(book1.title, "C++ 笔记");
 strcpy(book1.author, "HaiROng");
 strcpy(book1.subject, "编程语言");
 book1.bookId = 1234;

 // Book2 详述
 strcpy(book2.title, "css");
 strcpy(book2.author, "Runoob");
 strcpy(book2.subject, "前端技术");
 book2.bookId = 1235;

 // 输出book1信息
 cout << "book1 标题： " << book1.title << endl;
 cout << "book1 作者： " << book1.author << endl;
 cout << "book1 类别： " << book1.subject << endl;
 cout << "book1 ID： " << book1.bookId << endl;

 // 输出 book2 信息
 cout << "book2 标题： " << book2.title << endl;
 cout << "book2 作者： " << book2.author << endl;
 cout << "book2 类别： " << book2.subject << endl;
 cout << "book2 ID: " << book2.bookId << endl;

 return 0;
} */

/* #include <iostream>
#include <cstring>

using namespace std;

// 申明结构体类型 Boks
struct Books
{
 char title[50];
 char author[50];
 char subject[100];
 int bookId;
};

void printBook(struct Books book);

int main()
{
 Books book1; // 定义结构体类型 Books 类型变量 book1
 Books book2; // 定义结构体类型 Books 的变量 Book2

 // Book1 详述
 strcpy(book1.title, "C++ 笔记");
 strcpy(book1.author, "HaiROng");
 strcpy(book1.subject, "编程语言");
 book1.bookId = 1234;

 // Book2 详述
 strcpy(book2.title, "css");
 strcpy(book2.author, "Runoob");
 strcpy(book2.subject, "前端技术");
 book2.bookId = 1235;

 // 输出 book1信息
 printBook(book1);

 // 输出 book2 信息
 printBook(book2);
 return 0;
}

void printBook(struct Books book)
{
 cout << "Book 标题： " << book.title << endl;
 cout << "Book 作者： " << book.author << endl;
 cout << "Book 类别： " << book.subject << endl;
 cout << "Book ID： " << book.bookId << endl;
} */

/*
#include <iostream>
#include <cstring>

using namespace std;

// 申明结构体类型 Books
struct Books
{
 string title;
 string author;
 string subject;
 int bookId;

 // 构造函数
 Books(string t, string a, string s, int id)
     : title(t), author(a), subject(s), bookId(id) {}
};

// 打印书籍信息的函数，接受一个指向 Books 结构体的指针
void printBookInfo(Books *book)
{
 cout << "Book 标题： " << book->title << endl;
 cout << "Book 作者： " << book->author << endl;
 cout << "Book 类别： " << book->subject << endl;
 cout << "Book ID： " << book->bookId << endl;
}

int main()
{
 // 创建两本书的对象
 Books book1("C++ 笔记", "HaiRong", "编程语言", 1234);
 Books book2("CSS 教程", "Runoob", "前端技术", 12346);

 // 使用指针指像这两本书的对象
 Books *ptrBook1 = &book1;
 Books *ptrBook2 = &book2;

 // 传递指针打印书籍信息
 printBookInfo(ptrBook1);
 printBookInfo(ptrBook2);

 return 0;
}
 */

