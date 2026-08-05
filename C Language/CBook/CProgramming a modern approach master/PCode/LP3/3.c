#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int gs, identifier, publisher_code, item_num, check_digit;

 printf("Enter ISBN: ");
 scanf("%d-%d-%d-%d-%d", &gs, &identifier, &publisher_code, &item_num, &check_digit);
 printf("GS1 prefix: %d\nGroup identifier: %d\nPublisher code: %d\nItem number: %d\nCheck digit: %d\n", gs, identifier, publisher_code, item_num, check_digit);

 return 0;
}