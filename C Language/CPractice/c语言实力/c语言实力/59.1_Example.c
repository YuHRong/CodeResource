// 计算字符串中原音、辅音、数字、空格和其他字符长度。

#include<stdio.h>

int main(void)
{
 char str;
int i, numCount;

 printf("Input the string: \n");

 while ((str = getchar()) != '\n')
 {
if(str >= 1 && str <= 9)
numCount++;
 }
 
 printf("%d\n", numCount);

 return 0;
}