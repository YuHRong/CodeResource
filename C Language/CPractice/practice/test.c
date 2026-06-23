#include <stdio.h>

int main(void)
{
 int n[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

 for (int i = 0; i < 10; i++)
  n[i] = i;
 printf("%d \t %p\n", n[8], n[8]);

 return 0;
}