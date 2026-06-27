#include <stdio.h>

int main(void)
{
 int high = 100;               // 最高值
 int low = 1;                  // 最低值
 int guess = (high + low) / 2; // 初始中值
 int response;

 printf("Pick an integer from 1 to 100. I will try to guess ");
 printf("it.\nRespond with a y if my guess is right and with");
 printf("\nan n if it is wrong.\n");
 printf("Uh...is your number %d?\n", guess);

 while ((response = getchar()) != 'y')
 {
  if (response == '\n')
   continue;

  // 提示用户只能输入 y 或 n
  if (response != 'y' && response != 'n')
  {
   printf("I don't understand that response. Please enter y for\n");
   printf("no, n for no, or y for correct.\n");
   continue;
  }

  if (response == 'y')
  {
   // 当猜大了， high等于中值减1
   high = guess - 1;
  }
  else
  {
   // 当猜小了，low等于中值减1
   low = guess + 1;
  }
  // 计算中值
  guess = (high + low) / 2;

  // 继续猜测
  printf("Well, then, is it %d? [no:%d, yes:%d]\n", guess, low, high);
  // 循环截至条件，当最大值小于或等于最小值时，停止循环
  if (high <= low)
   break;
 }

 // 打印猜测值
 printf("The number is %d. I knew I could do it!\n", guess);

 return 0;
}