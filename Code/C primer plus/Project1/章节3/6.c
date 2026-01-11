#include<stdio.h>

int main(void)
{
 double watermolecule = 3.0e-23;
 double quart = 950.0;
 double waterquart, number;

 printf("Enter water quart please:");
 scanf_s("%lf", &waterquart);
 number = (quart * waterquart) / watermolecule;
 printf("WaterMoleclues is %.2e\n", number);

 return 0;
}