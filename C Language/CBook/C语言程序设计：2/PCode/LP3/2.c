#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int item_num, year, month, date;
 float price;

 printf("Enter item number: ");
 scanf("%d", &item_num);

 printf("Enter unit price: ");
 scanf("%f", &price);

 printf("Enter purchase date (mm/dd/yyyy): ");
 scanf("%d/%d/%d", &month, &date, &year);

 printf("Item\t\tUnit\t\tPurchase\n");
 printf("\t\tPrice\t\tDate\n");
 printf("%d\t\t $  %.2f\t\t%d/%.2d/%d\n", item_num, price, month, date, year);

 return 0;
}