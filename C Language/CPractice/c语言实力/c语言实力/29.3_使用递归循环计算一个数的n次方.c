#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int power(int n1, int n2);
int main(void)
{
 int b, p, result;

 printf("基数： ");
 scanf("%d", &b);
 printf("指数： ");
 scanf("%d", &p);

 result = power(b, p);
 printf("%d ^ %d = %d\n", b, p, result);

 return 0;
}

int power(int b, int p) {
 if (p != 0) 
 {
  return(b * power(b, p - 1));
 }
 else
 {
  return 1;
 }
}