#include <stdio.h>

int main()
{
 int array[10] = {0, 9, 8, 7, 6, 5, 4, 3, 2, 1};

 for (int loop = 9; loop >= 0; loop--)
  printf("%d ", array[loop]);

 return 0;
}