#include <stdio.h>

int main(void)
{
 int x, y;

 printf("Before swapping the value of x & y: ");
 scanf("%d %d", &x, &y);

 x = x ^ y;
 y = x ^ y;
 x = x ^ y;

 printf("After swapping the value of x & y : %d %d\n", x, y);

 return 0;
}