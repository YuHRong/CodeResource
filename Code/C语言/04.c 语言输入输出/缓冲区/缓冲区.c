#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
int main()
{
	int a = 1, b = 2;

	scanf("a=%d", &a);
	scanf("%*[^\n]"); scanf("%*c");  //在下次读取前清空缓冲区
	scanf("b=%d", &b);
	printf("a=%d, b=%d\n", a, b);

	return 0;
}