#include<stdio.h>

int main(void)
{
 float toobig = 9999999e100 * 100.0;
 float temp = 3.1234e-37 / 10;
 float toosmall = 3.1234e-38 / 10;

 printf("%f\n", toobig);
 printf("%f\n", temp);
 printf("%f\n", toosmall);

 return 0;
}