/* for_13s.c */
#include<stdio.h>
int main(void) {
 int n;         // 从2开始，每次递增13
 for (n = 2; n < 60; n = n + 13)
  printf("%d\n", n);
 return 0;
}