#include <stdio.h>

int main(void)
{
 int array[5][5];
 int row, col, total;

 for (row = 0; row < 5; row++)
 {
  printf("Enter row %d\n", row + 1);
  scanf("%d %d %d %d %d",
        &array[row][0], &array[row][1], &array[row][2], &array[row][3], &array[row][4]);
 }

 // 计算行的和
 printf("Row totals: ");
 for (row = 0; row < 5; row++)
 {
  total = 0;
  for (col = 0; col < 5; col++)
  {
   total += array[row][col];
  }
  printf("%d ", total);
 }

 // 计算列的和
 printf("\nColumn totals: ");
 for (col = 0; col < 5; col++)
 {
  total = 0;
  for (row = 0; row < 5; row++)
  {
   total += array[row][col];
  }
  printf("%d ", total);
 }
 return 0;
}