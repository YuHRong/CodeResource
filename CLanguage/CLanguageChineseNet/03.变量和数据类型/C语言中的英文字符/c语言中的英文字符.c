#include<stdio.h>

int main()

{
	char a = '1';
	char b = '$';
	char c = 'X';
	char d = ' ';

	// 使用putchar输出
	putchar(a); putchar(d);
	putchar(b); putchar(d);
	putchar(c); putchar('\n');
	// 使用printf输出
	printf("%c %c %c\n", a, b, c);

	return 0;
}

{
	char a = 'E';
	char b = 70;
	int c = 71;
	int d = 'H';

	printf("a: %c, %d\n", a, a);
	printf("b: %c, %d\n", b, b);
	printf("c: %c, %d\n", c, c);
	printf("d: %c, %d\n", d, d);

	return 0;
}
*/

{
	char web_url[] = "http://c.biancheng.net";
	char *web_name = "C语言中文网";

	puts(web_url);
	puts(web_name);
	printf("%s\n%s\n", web_url, web_name);

	return 0;
}
