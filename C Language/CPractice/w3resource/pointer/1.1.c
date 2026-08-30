// Write a C program to declare multiple pointers of different types (int, float, char) and print their addresses.

#include <stdio.h>

int main(void)
{
 int num = 10;
 float fNum = 10.0f;
 char ch = 'a';

 int *pD = &num;
 char *pCh = &ch;
 float *pF = &fNum;

 printf("Address int is : %p\n", (void *)pD);
 printf("Address char is : %p\n", (void *)pCh);
 printf("Address float is : %p\n", (void *)pF);

 return 0;
}