#include<stdio.h>
/*int main() {
	int i = 1, sum = 0;
	while (1) {//循环条件为死循环
		sum += i;
		i++;
		if (i > 100) break;  //跳出循环
	}
	printf("%d\n", sum);

	return 0;
}

//输出一个 4 * 4 的整数矩阵：
int main() {
	int i = 1, j;
	while(1){ //外层循环
		j = 1;
		while(1){//内层循环
			printf("%-4d", i * j);
			j++;
			if (j > 4) break;  //跳出内层循环
		}
		printf("\n");
		i++;
		if (i > 4) break;  // 跳出外层循环
	}

	return 0;
}*/

int main() {
	char c = 0;
	while (c != '\n') {  //回车键结束循环
		c = getchar();
		if (c == '4' || c == '5') {  //按下的是数字键4或5
			continue;  //跳过当次循环，进入下次循环
		}
		putchar(c);
	}
	return 0;
}