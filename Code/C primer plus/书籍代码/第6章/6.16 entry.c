/* entry.c -- 出口条件循环 */
#include<stdio.h>
int main(void) 
{
 const int secret_code = 13;
 int code_enter;
 printf("To enter the triskaidekaphobia therapy club,\n");
 printf("Please enter the secret code number: ");
 scanf_s("%d", &code_enter);
 while (code_enter != secret_code)
 {
  printf("To enter the triskaidekaphobia therapy club,\n");
  printf("Please enter the the secret code number: ");
  scanf_s("%d", &code_enter);
 }
 printf("Congratulations! You are cured!\n");
 return 0;
}