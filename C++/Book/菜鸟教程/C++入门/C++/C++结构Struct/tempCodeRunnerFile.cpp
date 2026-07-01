#include <iostream>
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
}