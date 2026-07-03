#include <stdio.h>

void to_base_n(unsigned long n, int base);

int main(void)
{
 unsigned long number;
 int base;

 printf("Enter two integers (q to quit):\n");
 while (scanf("%lu %d", &number, &base) == 2)
 {
  if (base < 2 || base > 10)
  {
   printf("Base must be between 2 and 10.\n");
   continue;
  }

  printf("Binary equivalent: ");
  to_base_n(number, base);
  putchar('\n');
  printf("Enter two integers (q to quit):\n");
 }
 printf("Done.\n");

 return 0;
}

void to_base_n(unsigned long n, int base) /* µİ¹éº¯Êı */
{
 int r;
 r = n % base;
 if (n >= base)
  to_base_n(n / base, base);
 putchar('0' + r);
 return;
}