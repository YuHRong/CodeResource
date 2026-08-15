// Write a program in C to copy the elements of one array into another array.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n;

 printf("copy the elements of one array into another array.\n");
 printf("-------------------------------------\n");

 printf("\nInput the number of elements to store in the array :\n");
 scanf("%d", &n);

 /*
  * 声明两个指向 int 类型的指针（arr 和 arrCopy），
  * 并为它们手动分配内存，用于存储两个数组的元素。
  * 如果任何一个内存分配失败（返回 NULL），
  * 程序将打印错误信息并返回 1 结束运行。
  */
 int *arr = (int *)malloc(n * sizeof(int));
 int *arrCopy = (int *)malloc(n * sizeof(int));
 if (arr == NULL || arrCopy == NULL)
 {                                       // 如果两个数组其中一个内存分配失败
  printf("Memory allocation failed!\n"); // 修正拼写错误
  return 1;
 }

 /*
  * 声明两个指针：
  * pArr：初始化为指向第一个数组 arr 的起始地址。
  * pArrCopy：初始化为指向第二个数组 arrCopy 的起始地址。
  *
  * 这些指针将用于遍历各自的数组，
  * 循环条件将直接使用指针与数组末尾地址的比较，
  * 例如 pArr < arr + n 和 pArrCopy < arrCopy + n。
  */
 int *pArr = arr;
 int *pArrCopy = arrCopy;

 /*
  * 提示用户输入 n 个数组元素。
  * 使用 `pArr < arr + n` 作为循环条件，当 `pArr` 指向的地址达到或超过 `arr` 数组的末尾地址时，循环结束。
  * 在循环内部：
  *   `printf("element - %d : ", (int)(pArr - arr));`：使用指针减法 `(pArr - arr)` 计算当前元素的索引（从 0 开始），并将其转换为 `int` 类型进行打印，作为用户输入的提示。
  *   `scanf("%d", pArr);`：使用解引用运算符 `*` 的隐式行为，通过 `pArr` 指针直接将用户输入的值存储到 `pArr` 当前指向的内存位置（即 `arr` 数组的当前元素）。
  *   `pArr++;`：将 `pArr` 指针移动到下一个 `int` 类型元素的位置。
  */
 while (pArr < arr + n)
 {
  printf("element - %d : ", (int)(pArr - arr));
  scanf("%d", pArr);
  pArr++;
 }

 /*
  * 将 `pArr` 指针重置回 `arr` 数组的起始地址，
  * 以便从头开始遍历并打印第一个数组的元素。
  * 在循环内部：
  *   `printf("%d ", *pArr);`：使用解引用运算符 `*` 获取 `pArr` 当前指向的内存位置的值，并打印出来。
  *   `pArr++;`：将 `pArr` 指针移动到下一个 `int` 类型元素的位置。
  */
 pArr = arr;
 printf("The elements stored in the first array are :\n");
 while (pArr < arr + n)
 {
  printf("%d ", *pArr);
  pArr++;
 }
 printf("\n");

 /*
  * 再次将 `pArr` 指针重置回 `arr` 数组的起始地址，用于复制操作。
  * `pArrCopy` 指针在之前已经初始化并指向 `arrCopy` 的起始地址，这里不需要重新初始化。
  * 循环条件 `pArr < arr + n` 确保遍历 `arr` 数组的所有元素。
  * 在循环内部：
  *   `*pArrCopy = *pArr;`：这是复制的核心。使用解引用运算符 `*` 获取 `pArr` 指向的值，并将其赋值给 `pArrCopy` 指向的内存位置。
  *   `pArr++;`：将 `pArr` 指针移动到 `arr` 数组的下一个元素。
  *   `pArrCopy++;`：将 `pArrCopy` 指针移动到 `arrCopy` 数组的下一个元素。
  */
 pArr = arr;
 while (pArr < arr + n)
 {
  *pArrCopy = *pArr;
  pArr++;
  pArrCopy++;
 }

 /*
  * 将 `pArr` 指针重置回 `arr` 数组的起始地址。
  * （注意：此行在此处是多余的，因为 `pArr` 在后续代码中没有被使用，但无害。）
  * 将 `pArrCopy` 指针重置回 `arrCopy` 数组的起始地址，
  * 以便从头开始遍历并打印复制后的数组元素。
  * 在循环内部：
  *   `printf("%d ", *pArrCopy);`：使用解引用运算符 `*` 获取 `pArrCopy` 当前指向的内存位置的值，并打印出来。
  *   `pArrCopy++;`：将 `pArrCopy` 指针移动到下一个 `int` 类型元素的位置。
  */
 pArr = arr;         // 这一行是多余的，可以删除
 pArrCopy = arrCopy; // 将复制数组的指针初始化为第二个数组内存的开始处

 // 打印复制后的数组
 printf("The elements copied into the second array are :\n");
 while (pArrCopy < arrCopy + n)
 {
  printf("%d ", *pArrCopy);
  pArrCopy++;
 }
 printf("\n");

 /*
  * 释放之前通过 `malloc` 分配的内存，防止内存泄漏。
  * 将 `arr` 和 `arrCopy` 指针设置为 `NULL`，
  * 这是一个良好的编程习惯，可以避免悬空指针的误用。
  */
 free(arr);
 arr = NULL;
 free(arrCopy);
 arrCopy = NULL;

 return 0;
}
