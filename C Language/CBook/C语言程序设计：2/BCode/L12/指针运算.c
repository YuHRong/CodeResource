#include<stdio.h>

int main(void)
{
 int a[10], * p, * q, i;
 p = &a[2];
 q = p + 3;
 //p += 6;
 printf("%p\n", q);
 return 0;
}