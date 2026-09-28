// Write a program that converts Centigrade to Fahrenheit.

#include <stdio.h>

#define CEL_FAH 1.8 // 定义摄氏度转华氏度的常量

int main(void)
{
 double celsius, fahrenheit;
 char line_text[50]; // 一行输入

 printf("Input a temperature (in Centigrade): ");

 // 读取一行输入并将其存储在“line_text”中。
 fgets(line_text, sizeof(line_text), stdin);
 // 将输入从“line_text”转换为浮点数并将其存储在 celsius中
 sscanf(line_text, "%lf", &celsius);

 fahrenheit = (celsius * CEL_FAH) + 32;

 printf("%lf degrees Fahrenheit.\n", fahrenheit);

 return 0;
}