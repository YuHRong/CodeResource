
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

 printf("%-15s0  1  2  3  4  5  6  7  8  9\n", "Digit:");
 printf("%-15s", "Occurences:");
 for (n = 0; n < 10; n++)
  printf("%ld ", digit_seen[n]);

return 0;
}