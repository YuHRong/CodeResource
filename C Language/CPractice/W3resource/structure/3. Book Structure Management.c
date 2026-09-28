// Create a structure named Book to store book details like title, author, and price. Write a C program to input details for three books, find the most expensive and the lowest priced books, and display their information.

#include <stdio.h>

#define SI 100 // 定义字符串数组长度
// 定义 Book 结构体
struct Book
{
 char title[SI];
 char author[SI];
 float price;
};

int main(void)
{
 struct Book b1, b2, b3;

 // 输入第一本书的信息
 printf("Input details for Book 1:\n");
 printf("Title: ");
 scanf("%s", b1.title);
 printf("Author: ");
 scanf("%s", b1.author);
 printf("Price: ");
 scanf("%f", &b1.price);

 // 输入第二本书的信息
 printf("Input details for Book 2:\n");
 printf("Title: ");
 scanf("%s", &b2.title);
 printf("Author: ");
 scanf("%s", b2.author);
 printf("Price: ");
 scanf("%f", &b2.price);

 // 输入第三本书的信息
 printf("Input details for Book 3:\n");
 printf("Title: ");
 scanf("%s", b3.title);
 printf("Author: ");
 scanf("%s", b3.author);
 printf("Price: ");
 scanf("%f", &b3.price);

 // 找到最贵的书
 struct Book mostExpensive;
 if (b1.price >= b2.price && b1.price >= b3.price)
 {
  mostExpensive = b1;
 }
 else if (b2.price >= b1.price && b2.price >= b3.price)
 {
  mostExpensive = b2;
 }
 else
 {
  mostExpensive = b3;
 }

 // 找到最便宜的书
 struct Book lowestPriced;
 if (b1.price <= b2.price && b1.price <= b3.price)
 {
  lowestPriced = b1;
 }
 else if (b2.price <= b1.price && b2.price <= b3.price)
 {
  lowestPriced = b2;
 }
 else
 {
  lowestPriced = b3;
 }

 // 显示最贵的书
 printf("\nMost Expensive Book:\n");
 printf("Title: %s\n", mostExpensive.title);
 printf("Author: %s\n", mostExpensive.author);
 printf("Price: %.2f\n", mostExpensive.price);

 // 显示最便宜的书
 printf("\nLowest Priced Book:\n");
 printf("Title: %s\n", lowestPriced.title);
 printf("Author: %s\n", lowestPriced.author);
 printf("Price: %.2f\n", lowestPriced.price);

 return 0;
}