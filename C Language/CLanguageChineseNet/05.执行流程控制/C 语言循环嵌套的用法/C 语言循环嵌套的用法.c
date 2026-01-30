//示例1：演示 for 循环嵌套的执行流程。
/*#include<stdio.h>

int main() {
	int i, j;
	for (i = 1; i <= 4; i++) {  //外层for循环
		for (j = 1; j <= 4; j++) {  //内层for循环
			printf("i=%d, j=%d\n", i, j);
		}
		printf("\n");
	}
	return 0;
}

//示例2：输出一个4×4的整数矩阵。
#include<stdio.h>
int main() 
{
	int i, j;
	for (i = 1; i <= 4; i++) {  //外层for循环
		for (j = 1; j <= 4; j++) {  //内层for循环
			printf("%-4d", i * j);
		}
		printf("\n");
}
	return 0;
}*/


//示例3：输出九九乘法表。
#include<stdio.h>
int main() {
	int i, j;
	for (i = 1; i <= 9; i++) { //外层 for 循环
		for (j = 1; j <= i; j++) { //内层 for 循环
			printf("%d*%d=%-2d  ", i, j, i * j);
		}
		printf("\n");
	}

	return 0;
}