#include<stdio.h>

void br(void);
void ic(void);
int main(void) {
	printf("Brazil, Russia, India, china\n");
	ic();
	printf(",\n");
	br();

	return 0;
}

//定义函数值
void br(void) {
	printf("Brazil, Russia\n");
}
void ic(void) {
	printf("India, China");
}