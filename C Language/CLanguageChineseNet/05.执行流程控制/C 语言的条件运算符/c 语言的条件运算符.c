//使用条件运算符输出两个数中的较大者。

#include<stdio.h>

//int main() {
	/*int a, b;
	printf("输入两个整数");
	scanf_s("%d %d", &a, &b);
	printf("较大的数字是：%d\n", a > b ? a: b);

	return 0;
}*/

	//使用条件表达式来决定调用哪个函数。

void success() {
	puts("succeed!");
}

void fail() {
	puts("Failed!");
}

int main() {
	int isOK = 1;  // 1 表示真，0 表示假
	isOK ? success() : fail();

	return 0;
}