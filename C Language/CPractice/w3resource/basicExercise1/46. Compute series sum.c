// Compute series sum S=1+3/2+5/4+7/8
// Write a C program to calculate the value of S where S = 1 + 3/2 + 5/4 + 7/8.
/*
 加法使用奇数进行累加，
被除数使用偶数进行计算
循环条件，
i = 1.0
i <= 8.0
在循环内部，找出分子
分子 等于 2 * i - 1
在循环外部定义一个求分母变量
n = 1.0
最后求职
和 = 分子 / 分母
重新赋值
n = n * 2
以后每一次循环 n * 2求出最后的分母
1, 2, 4, 8
分子等于
1, 3, 5, 7
*/

/* #include <stdio.h>

int main()
{
 float sum = 0.0, n = 1.0;
 float odd, even;

 for (float i = 1.0; i <= 4; i++)
 {
  odd = (float)2.0 * i - 1;
  even = n;

  sum += odd / even;

  n = n * 2;
 }

 printf("Vallue of series: %.2f\n", sum);

 return 0;
} */
#include <stdio.h>
int main() {
    double s=0, j=1, d, i;

    // Loop to calculate the series
    for(i=1; i<=7; i+=2){
        d = (i/j);
        s += d;
        j = j*2;
    }

    // Print the result
    printf("Value of series: %.2lf\n", s);

    return 0;
}
