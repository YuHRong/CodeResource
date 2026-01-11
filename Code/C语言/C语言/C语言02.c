// 区分不同进制数字的一个简单办法，在输出时带上特定的前缀。在格式控制符中加上
// #即可输出前缀，例如 
// % #x、 % #o、 % #lX、 % #ho 等，请看下面的代码：

#include<stdio.h>

void printNumbers()
{
short a = 0b1010;  //二进制数字
int b = 012;  //八进制数字
long c = 0XA;  //十六进制数字
long long d = 10;

//以八进制形式输出
printf("a=%#ho, b=%#o, c=%#lo, d=%#llo\n", a, b, c, d);

// 以十进制形式输出
printf("a=%hd, b=%d, c=%ld, d=%lld\n", a, b, c, d);

// 以十六进制输出，字母小写
printf("a=%#hx, b=%#x, c=%#lx, d=%#llx\n", a, b, c, d);

// 以十六进制输出，字母大写
printf("a=%#hX, b=%#X, c=%#lX, d=%#llX\n", a, b, c, d);

// 十进制没有前缀#，所以不需要加
}