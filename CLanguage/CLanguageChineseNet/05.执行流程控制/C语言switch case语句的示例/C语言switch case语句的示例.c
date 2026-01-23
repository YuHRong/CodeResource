#include<stdio.h>

/*int main() {
	int a;
	printf("Input integer number:");
	scanf_s("%d", &a);

	switch (a) {
	case 1:
		printf("monday\n");
//		break;
case 2:
	printf("Tuesday\n");
	//break;
case 3:
	printf("Wednesday\n");
	//break;
case 4:
	printf("Thursday\n");
	//break;
case 5:
	printf("Friday\n");
	//break;
case 6:
	printf("Saturday\n");
	//break;
case 7:
	printf("Sunday\n");
	//break;
default:
	printf("error\n");
	}

	return 0;
}

//使用 switch case 语句实现一个简单的加法器。

int main() {
	char symbol;
	double num1, num2, result;

	printf("输入一个运算符 (+, -, *, /): ");
	scanf_s("%c", &symbol);
	printf("输入两个数字");
	scanf_s("%lf %lf", &num1, &num2);

	switch (symbol) {
	case '+':
		result = num1 + num2;
		printf("%.2lf + %.2lf = %.2lf\n", num1, num2, result);
		break;
	case '-':
		result = num1 - num2;
		printf("%.2lf - %.2lf = %.2lf\n", num1, num2, result);
		break;
	case '*':
		result = num1 * num2;
		printf("%.2lf * %.2lf = %.2lf\n", num1, num2, result);
		break;
	case '/':
		if (num2 != 0) {
			result = num1 / num2;
			printf("%.2lf / %.2lf = %.2lf\n", num1, num2, result);
		}
		else
		{
			printf("错误！除数不能为0\n");
		}
		break;
	default:
		printf("错误！无效的运算符\n");
	}

	return 0;
}*/

//输入月份，输出季节。

int main() {
	int month = 0;
	printf("输入月份");
	scanf_s("%d", &month);

	switch (month) {
	case 12:
	case 1:
	case 2:
		printf("冬季\n");
		break;
	case 3:
	case 4:
	case 5:
		printf("春季\n");
		break;
	case 6:
	case 7:
	case 8:
		printf("夏季\n");
		break;
	case 9:
	case 10:
	case 11:
		printf("秋季\n");
		break;
	default:
		printf("无效的月份\n");
	}

	return 0;
}