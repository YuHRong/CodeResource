//定义两个函数分别为： br() 和 ic()
#include<stdio.h>

void br(void);
void ic(void);
int main(void)
{
 printf("Brazil, Russia, India, China\n");
 ic();
 br();
 return 0;
}

void br(void)
{
 printf("Brazil, Russia\n");
}

void ic(void)
{
 printf("India, China\n");
}