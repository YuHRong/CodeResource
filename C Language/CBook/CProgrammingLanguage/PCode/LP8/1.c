
#include <stdio.h>

int main(void)
{
int digit_seen[10] = {0};
 int digit;
 long n;

 printf("Enter a number: ");
 scanf("%ld", &n);

 while (n > 0)
 {
  digit = n % 10;
  digit_seen[digit]++;
  n /= 10;
 }

 printf("Repeated digit(s): ");
 for (n = 0; n < 10; n++)
 {
  if (digit_seen[n] > 1)
   printf("%ld ", n);
 }

 return 0;
}