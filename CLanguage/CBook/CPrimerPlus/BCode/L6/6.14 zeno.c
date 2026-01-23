/* zeno.c -- 求序列的和 */
#include<stdio.h>
int main(void) {
 int t_ct;     //项技数
 double time, power_of_2;
 int limet;
 printf("Enterthe number of terms you want: ");
 scanf_s("%d", &limet);
 for (time = 0, power_of_2 = 1, t_ct = 1; t_ct <= limet;
  t_ct++, power_of_2 *= 2.0)
 {
  time += 1.0 / power_of_2;
  printf("time = %f when terms = %d.\n", time, t_ct);
 }
 return 0;
}