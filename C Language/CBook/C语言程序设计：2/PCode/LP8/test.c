#include <stdio.h>

int main(void)
{
 int row[5][5];
 int i, j;

 for (i = 0; row[i] <= 5; i++)
 {
  printf("Enter row %d\n", i);
  scanf("%d", row[i]);
 }

 return 0;
}