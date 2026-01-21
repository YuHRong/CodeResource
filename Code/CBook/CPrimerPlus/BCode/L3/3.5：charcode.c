/* charcode.c-ÏÔÊ¾×Ö·ûµÄ´úÂë±àºÅ */
#include<stdio.h>
int main(void) {
	char ch;

	printf("please enter a character.\n");
	scanf_s("%c", &ch);
	printf("the code or %c is %d.\n", ch, ch);

	return 0;
}