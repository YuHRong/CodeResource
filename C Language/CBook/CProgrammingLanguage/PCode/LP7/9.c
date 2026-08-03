#include <stdio.h>
#include<ctype.h>

int main(void)
{
 int hours, minute, offset;
 char ch;

 printf("Enter a 12-hour time: ");
 scanf("%d :%d %c", &hours, &minute, &ch);

 /* Create an offset to add to the hour if time is PM */
 offset = (toupper(ch) == 'P' ? 12 : 0);
 hours = (hours == 12 ? 0 : hours);

 printf("Equivalent 24-hour time: %2d:%2d\n", hours + offset, minute);

 return 0;
}
