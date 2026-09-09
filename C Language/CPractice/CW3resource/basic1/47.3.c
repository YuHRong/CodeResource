// Write a C program to count the total number of divisors of a user-entered integer.
// Write a C program to calculate the sum of all divisors of a given integer.
// Write a C program to list all divisors of a given integer in both ascending and descending order.

#include <stdio.h>
#include <stdlib.h>

typedef struct
{
 int *divisor;
 int count;
} DivisorCollection;

DivisorCollection collectDivisors(int n);

void divisorAscendingOrder(const int divisors[], int n);
void divisorDescendingOrder(const int divisors[], int n);
int getDivisorCount(const int divisor[], int count);
int sumAllDivisors(const int divisor[], int count);

int main()
{
 int n;

 printf("Input an integer: ");
 scanf("%d", &n);

 DivisorCollection allDivs = collectDivisors(n);

 if (allDivs.divisor == NULL && n > 0) // > 0表示内存分配失败
 {
  printf("Error: Memory allocation failed.\n");
  return 1;
 }

 // 2. 将收集到的因数数组传递给其他函数
 printf("Divisors in ascending order:\n");
 divisorAscendingOrder(allDivs.divisor, allDivs.count);

 printf("Divisors in descending order:\n");
 divisorDescendingOrder(allDivs.divisor, allDivs.count);

 printf("Total number of divisors: %d\n", getDivisorCount(allDivs.divisor, allDivs.count));
 printf("Sum of all divisors: %d\n", sumAllDivisors(allDivs.divisor, allDivs.count));

 // 释放动态分配的内存
 if (allDivs.divisor != NULL)
 {
  free(allDivs.divisor);
 }

 return 0;
}

// 收集所有因数函数
DivisorCollection collectDivisors(int n)
{
 DivisorCollection result = {NULL, 0};
 int *temp_divs = NULL;
 int current_count = 0;

 for (int i = 1; i <= n; i++)
 {
  if ((n % i) == 0)
  {
   // 动态扩展数组
   temp_divs = (int *)realloc(temp_divs, (current_count + 1) * sizeof(int));
   if (temp_divs == NULL)
   {
    // 内存分配失败，返回空列表
    result.divisor = NULL;
    result.count = current_count; // 返回已收集的数量，或者0表示失败
    return result;
   }

   temp_divs[current_count++] = i;
  }
 }

 result.divisor = temp_divs;
 result.count = current_count;
 return result;
}

// 因数升序排序函数定义
void divisorAscendingOrder(const int divisors[], int count)
{
 if (divisors == NULL || count == 0)
 {
  // 处理空列表或错误情况
  return;
 }

 for (int i = 0; i < count; i++)
 {
  printf("%d\n", divisors[i]);
 }
}

// 因数降序排序函数定义
void divisorDescendingOrder(const int divisors[], int count)
{
 if (divisors == NULL || count == 0)
 {
  // 处理空列表或错误情况
  return;
 }

 for (int i = count - 1; i >= 0; i--)
 { // 反向遍历
  printf("%d\n", divisors[i]);
 }
}

// 因数计数函数定义
int getDivisorCount(const int divisors[], int count)
{
 return count; // 直接返回传入的 count
}

// 因数求和函数定义
int sumAllDivisors(const int divisors[], int count)
{
 if (divisors == NULL || count == 0)
 {
  return 0; // 空列表和为0}
 }

 int sum = 0;

 for (int i = 0; i < count; i++)
 {
  sum += divisors[i];
 }

 return sum;
}