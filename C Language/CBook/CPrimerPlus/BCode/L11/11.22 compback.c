/* compback.c -- strcmp()µÄ·µ»ØÖµ */
#include<stdio.h>
#include<string.h>

int main(void)
{
printf("strcmp(\"A\", \"A\") is ");
 printf("%d\n", strcmp("A", "A"));
 printf("strcmp(\"A\", \"B\") is ");
 printf("%d\n", strcmp("A", "b"));
 printf("strcmp(\"B\", \"A\") is ");
 printf("%d\n", strcmp("B", "A"));
 printf("strcmp(\"C\", \"A\") is ");
 printf("%d\n", strcmp("C", "A"));
 printf("strcmp(\"Z\", \"A\") is ");
 printf("%d\n", strcmp("Z", "A"));
 printf("strcmp(\"ampples\", \"apple\" is ");
 printf("%d\n", strcmp("apples", "apple"));
}