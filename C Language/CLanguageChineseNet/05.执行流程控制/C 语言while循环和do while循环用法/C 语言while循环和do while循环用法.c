//用 while 循环计算从 1 加到 100 的值。

#include<stdio.h>
/*int main() {
	int i = 1, sum = 0;
	while (i <= 100) {
		sum += i;
		i++;
	}
	printf("1加到100的和为:%d\n", sum);

	return 0;
}

//循环中不包含变量

int main() {
	while (1) {
		printf("*");
	}

	return 0;
}

//循环开始点不成立
int main() {
	int i = 10;

	while (i < 5) {
		printf("This will never be printed\n");
		i++;
	}

	printf("Loop finished. i = %d)\n", i);

	return 0;
}

//用 do while 循环计算从 1 加到 100 的值。
int main() {
	int i = 1, sum = 0;
	do {
		sum += i;
		i++;
	} while (i <= 100);
	printf("1加到100的和为:%d\n", sum);

	return 0;
}

//统计从键盘输入的字符串所包含的字符个数。
int main() {
	int n = 0;
	printf("请输入一个字符串回车结束");
	while (getchar() != '\n') {
		n++;
	}
	printf("字符的个数为:%d\n", n);

	return 0;
}*/

//计算 n 的阶乘，也即n!
int main() {
	int n, factorial = 1;
	int temp;

	printf("请输入一个正整数");
	scanf_s("%d", &n);

	temp = n;
	while (temp > 0) {
		factorial *= temp;
		temp--;
	}
	printf("%d 的阶乘是%d\n", n, factorial);

	return 0;
}