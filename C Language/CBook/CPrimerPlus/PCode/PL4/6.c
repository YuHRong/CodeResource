#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>

int main(void)
{
 char firstName[20];
 char lastName[20];

 printf("«Î ‰»Î√˚◊÷:\n");
 scanf("%s", firstName);
 printf("«Î ‰»Î–’:\n");
 scanf("%s", lastName);

 printf("%s %s\n", firstName, lastName);
 printf("%*u %*u\n", strlen(firstName), strlen(firstName), strlen(lastName), strlen(lastName));

 printf("%s %s\n", firstName, lastName);
 printf("%-*u %-*u\n", strlen(firstName), strlen(firstName), strlen(lastName), strlen(lastName));

 return 0;
}