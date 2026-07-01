#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>

#define NUM_ROWS 10
#define NUM_COLS 10
#define EMPTY_CELL ' '

#define NUM_MOVES 4
#define LEFT 0
#define DOWN 1
#define UP 2
#define RIGHT 3

int main(void)
{
 char letter, grid[NUM_ROWS][NUM_COLS];
 bool potential_move[NUM_MOVES];
 int i, row, col, potential_move_count, generated_move;

 srand((unsigned)time(NULL));
 // 用 ' 单引号填充网格
 for (row = 0; row < NUM_ROWS; row++)
 {
  for (col = 0; col < NUM_COLS; col++)
  {
   grid[row][col] = '.';
  }
 }

 // 通过网格执行网格跟踪
 row = 0;
 col = 0;
 for (letter = 'A'; letter <= 'Z'; letter++)
 {
  grid[row][col] = letter;

  // 重置当前单元格的 potential_move 数组和标记
  for (i = 0; i < NUM_MOVES; potential_move[i] = false, i++)
   ; // 空循环体
  potential_move_count = 0;

  // 查找当前单元格中所有可能的移动
  if (col - 1 >= 0 && grid[row][col - 1] == EMPTY_CELL)
  {
   potential_move[LEFT] = true;
   potential_move_count++;
  }

  if (row + 1 < NUM_ROWS && grid[row + 1][col] == EMPTY_CELL)
  {
   potential_move[DOWN] = true;
   potential_move_count++;
  }

  if (row - 1 >= 0 && grid[row - 1][col] == EMPTY_CELL)
  {
   potential_move[UP] = true;
   potential_move_count++;
  }

  if (col + 1 < NUM_COLS && grid[row][col + 1] == EMPTY_CELL)
  {
   potential_move[RIGHT] = true;
   potential_move_count++;
  }

  // 如果当前单元格无法移动，则停止移动
  if (potential_move_count == 0)
   break;

  // 生成一个随机移动，直到匹配到潜在移动后在移动
  while (true)
  {
   generated_move = rand() % NUM_MOVES;

   if (potential_move[generated_move] == true)
   {
    switch (generated_move)
    {
    case LEFT:
     col--;
     break;
    case DOWN:
     row++;
     break;
    case UP:
     row--;
     break;
    case RIGHT:
     col++;
     break;
    }
    break; // 生成的移动中止
   }
   else
   {
    continue; // 继续生成移动
   }
  }
 }

 // 打印网格
 for (row = 0; row < 10; row++)
 {
  for (col = 0; col < 10; col++)
  {
   printf("%2c", grid[row][col]);
  }
  printf("\n");
 }

 return 0;
}