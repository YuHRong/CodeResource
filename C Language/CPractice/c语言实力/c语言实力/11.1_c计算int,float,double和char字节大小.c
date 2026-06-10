//使用 sizeof 操作符计算int, float, double 和 char四种变量字节大小。
//sizeof 是 C 语言的一种单目操作符，如C语言的其他操作符++、--等，它并不是函数。
//sizeof 操作符以字节形式给出了其操作数的存储大小。
#include<stdio.h>

int main(void)
{
 int integerType;
 float floatType;
 double doubleType;
 char charType;

 // 使用 sizeof 计算变量的字节大小
 printf("Sizeof of int: %ld bytes\n", sizeof(integerType));
 printf("Float of float: %ld bytes\n", sizeof(float));
 printf("Size of double: %ld bytes\n", sizeof(double));
 printf("Size of char: %ld bytes\n", sizeof(char));

 return 0;
}