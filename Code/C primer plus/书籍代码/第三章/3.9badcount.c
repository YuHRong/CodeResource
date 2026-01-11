/* badcount.c -- 参数错误的情况 */
#include<stdio.h>

int main(void) {
	int n = 4;
	int n = 5;
	float f = 7.0f;
	float g = 8.0;

	printf("%d\n", n, m);    /* 参数太多  */
	printf("%d %d %d\n", n); /* 参数太少  */
	printf("%d %d\n", f, g); /* 值的类型不匹配 */

	return 0;
}