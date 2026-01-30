#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 double watermolecule = 3.0e-23;
 double quart = 950.0;
 double waterquart, number;

 printf("Enter water quart please:");
 scanf("%lf", &waterquart);
 number = (quart * waterquart) / watermolecule;
 printf("WaterMoleclues is %.2e\n", number);

 return 0;
}