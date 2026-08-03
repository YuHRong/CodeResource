#include<stdio.h>

int main(void)
{
 int a[10], *p;

 // p 指向 a[0]
 p = &a[5];

 // 给 a[0] 存入一个值
 *p = 5;

 printf("%d 指针地址: %p\n", a[0], p);

 return 0;
}