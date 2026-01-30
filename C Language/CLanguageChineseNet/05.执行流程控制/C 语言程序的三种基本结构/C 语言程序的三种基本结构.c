#include<stdio.h>
/*
int main() {
	float length, width, area;

	length = 5.0;
	width = 3.0;
	area = length * width;

	printf("长方形的面积是：%.2f\n", area);

	return 0;
}

int main() {
	int number;

	printf("请输入一个整数：");
	scanf_s
	("%d", &number);

	if (number % 2 == 0) {
		//这是第一个代码块
		printf("%d 是偶数\n", number);
	} else {
		//这是第二个代码块
		printf("%d 是基数\n", number);
	}

	return 0;
} 

int main() {
	int sum = 0;

	for (int i = 1; i <= 100; i++) {
		//这是重复执行的代码块
		sum += i;
	}

	printf("1 到 100 的和是:%d\n", sum);

	return 0;
}*/

int main() {
	int i, j;
	for (i = 1; i < 5; i++) {
		for (j = 1; j < 5; j++) {
			if (i == 2 && j == 2) {
				goto end_loop;
			}
			printf("i = %d, j =%d\n", i, j);
		}
	}

	end_loop:
	printf("跳出循环\n");

	return 0;
}