// Write a C program to declare a pointer, assign it the address of a variable, and then change the variable’s value using the pointer.

#include <stdio.h>

int main(void)
{
 int x = 5;
 int *pX = &x;

 printf("value of the x is : %d\n", x);

 // 使用指针修改 x 的值
 *pX = 10;
 printf("value revise is : %d\n", x);

 return 0;
}