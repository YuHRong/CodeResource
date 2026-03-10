#include<stdio.h>

#define N 10

int main(void)
{
 int a[N], sum, * p;
 sum = 0;

 for (p = &a[0]; p < &a[N]; p++)
 {
  sum += *p;
 }
}