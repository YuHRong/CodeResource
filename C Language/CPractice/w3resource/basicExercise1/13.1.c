// À©Õ¹
#include <stdio.h>

int main(void)
{
 int n1, n2, n3, max = 0;

 printf("Input the first integer: ");
 scanf("%d", &n1);
 printf("Input the second integer: ");
 scanf("%d", &n2);
 printf("Input the third integer: ");
 scanf("%d", &n3);

 max = (n1 > n2) ? ((n1 > n3) ? n1 : n3) : ((n2 > n3) ? n2 : n3);

 printf("%d\n", max);

 return 0;
}