#include<stdio.h>

// 自定义函数smile
void smile();
int main(void) {
	smile(); smile(); smile();
	printf("\n");
	smile(); smile();
	printf("\n");
	smile();

	return 0;
}

// 函数体
void smile(void)
{
	printf("Smile!");
}