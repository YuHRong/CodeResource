# C++ 结构

结构体是一种用户自定义数据类型，用于将不同数据类型组合在一起。结构允许自定义成员变量和成员函数。


使用 `struct` 语句来定义结构。

·struct· 语句定义了一个包含多个成员的新的数据类型，·struct· 语句的格式如下：

```c++
struct type_name{    // type_name 结构名称
num_type1 num_name1;    // 变量定义，如： int 类型double 类型，float 类型等。
num_type2 num_name2;
...
}  object_name;
```

结构体优点：
- `简单数据封装` ：适合封装多种类型的简单数据，通常用于数据的存储。
- `轻量级` ：相比 class ，结构体语法更简洁，适合小型数据对象。
- `面向对象支持` ：支持构造函数、成员函数和访问权限控制，可以实现面向对象的设计。

## 访问结构成员

在访问结构成员时使用成员访问运算符`.`英文句号进行访问。

### 实力

```c++
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
}
```

输出： 

```
book1 标题： C++ 笔记
book1 作者： HaiROng
book1 类别： 编程语言
book1 ID： 1234
book2 标题： css
book2 作者： Runoob
book2 类别： 前端技术
book2 ID: 1235
```

## 结构作为函数参数

结构作为函数参数传参方式与其他类型的变量或指针类似。

可以使用上面实例中的方式来访问结构变量：

### 实力

```c++
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
}
```

输出： 

```c++
Book 标题： C++ 笔记  
Book 作者： HaiROng  
Book 类别： 编程语言  
Book ID： 1234  
Book 标题： css  
Book 作者： Runoob  
Book 类别： 前端技术  
Book ID： 1235  
```

### 结构体的各个部分详细介绍

- `struct 关键字`：  用于定义结构体，它告诉编译器后面要定义的是一个自定义类型。
- `成员变量`：  成员变量是结构体中定义的数据项，它们可以是任何基本类型或其他自定义类型。在 struct 中，这些成员默认是 public，可以直接访问。
- `成员函数`：  结构体中也可以包含成员函数，这使得结构体在功能上类似于类。成员函数可以操作结构体的成员变量，提供对数据的封装和操作。
- `访问权限`：  与 class 类似，你可以在 struct 中使用 public、private 和 protected 来定义成员的访问权限。在 struct 中，默认所有成员都是 public，而 class 中默认是 private。

## 只想结构的指针

您可以定义指向结构的指针，方式与定义指向其他类型变量的指针相似，如下所示：
```c++
struct Books *struct_pointer;
```

以上代码定义了一个指向 `Books` 结构体的指针 `struct_pointer`。
现在，可以在上述定义的指针变量中存储结构变量的地址。为了查找结构变量的地址，请把 `&` 运算符放在结构名称的前面，如下：

```c++
struct_pointer = &book1;
```

以上代码将 `book1` 结构体变量的地址赋值给 `struct_pointer`。
为了使用指向该结构的指针访问结构的成员，您必须使用 `->` 运算符，如下：

```c++
struct_pointer->title;
```

以上代码通过 `struct_pointer` 访问 `book1` 结构体的 `title` 成员。

### 实力

使用结构指针重写上述实力

```c++
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
```

输出： 

```
Book 标题： C++ 笔记
Book 作者： HaiRong
Book 类别： 编程语言
Book ID： 1234
Book 标题： CSS 教程
Book 作者： Runoob
Book 类别： 前端技术
Book ID： 12346
```

#### 说明

结构体定义： `Books` 结构体的定义与之前相同，包含 `title`、`author`、 `subject` 和 `bookId` 四个成员变量，并且有一个`构造函数`用于初始化这些成员。 

`printBookInfo` 函数：现在这个函数接受一个指向  `Books` 结构体的指针  `const Books *book` 。在函数内部，使用 `->` 操作符来访问`结构体指针`所指向的`成员变量`。 `main 函数`：创建两个 `Books` 类型的对象 `book1` 和 `book2`。

使用 `&` 操作符获取这两个对象的地址，并将它们赋值给指针 `ptrBook1` 和 `ptrBook2`。调用 `printBookInfo` 函数时，传递的是指向 `Books` 对象的指针。

## typedef 关键字

下面是一种更简单的定义结构的方式，您可以为创建的类型取一个"别名"。例如：

```c++
typedef struct Books
{
   char  title[50];
   char  author[50];
   char  subject[100];
   int   bookId;
}Books;
```

 现在，可以直接使用 `Books` 来定义 `Books`  类型的变量，而不需要使用 `struct` 关键字。下面是实例：

 ```c++
 Books Book1, Book2;
 ```

可以使用 `typedef` 关键字来定义非结构类型，如下所示：

```c++
typedef long int *pint32;
pint32 x, y, z;
```

`x`, `y` 和 `z` 都是指向长整型 `long int` 的指针。

## 结构体与类的区别

在 C++ 中，`struct` 和 `class` 本质上非常相似，唯一的区别在于默认的访问权限： `struct` 默认的成员和继承是 `public` 。`class` 默认的成员和继承是 `private`。  
可以将 `struct` 当作一种简化形式的 `class` ，适合用于没有太多复杂功能的简单数据封装。

## 结构体与函数的结合

你可以通过构造函数初始化结构体，还可以通过引用传递结构体来避免不必要的拷贝。

### 实力

```c++
struct Books
{
 string title;
 string author;
 string subject;
 int book_id;

 // 构造函数
 Books(string t, string a, string s, int id)
     : title(t), author(a), subject(s), book_id(id)
 {
 }
 void printInfo() const
 {
  cout << "书籍标题: " << title << endl;
  cout << "书籍作者: " << author << endl;
  cout << "书籍类目: " << subject << endl;
  cout << "书籍 ID: " << book_id << endl;
 }
};
void printBookByRef(const Books &book)
{
 book.printInfo();
}
```

--------------------------------------------------
