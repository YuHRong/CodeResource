#include<stdio.h>

int main(void)
{
int ch;
int count = 0;

while ((ch = getchar()) != EOF)
{
count++;
}
printf("%d characters read.\n", count);

return 0;
}