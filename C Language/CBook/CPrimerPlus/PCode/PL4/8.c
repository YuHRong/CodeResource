#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
/*constªÚ’ﬂdefine
#define TRANS_GL 3.785
#define TRANS_MM 1.609
*/
int main(void)
{
 const float TRANS_GL = 3.785;
 const float TRANS_MM = 1.609;

 float distance, gallon;
 printf("Please enter the mileage of your trip:\n");
 scanf("%f", &distance);
 printf("Please enter the gallons you consumption:\n");
 scanf("%f", &gallon);
 printf("The speed is %.1f (mile/gallon)\n", distance / gallon);
 printf("The speed is %.1f (L/100km)\n", (gallon * TRANS_GL) / (distance * TRANS_MM * 100));
 return 0;
}