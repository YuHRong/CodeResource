// 用C语言写一个程序，演示如何在程序中处理指针。
#include <stdio.h> // 包含标准输入输出库，用于printf函数

int main(void) // 主函数，程序入口
{
 // 声明并初始化一个整型变量m，赋值为29
 int m = 29;

 // 声明一个整型指针ab，并初始化为m的地址（&m表示取m的地址）
 int *ab = &m;

 // 打印变量m的地址，%p用于打印指针地址，(void *)&m将m的地址转换为void*类型
 printf("Address of m : %p\n", (void *)&m);

 // 打印变量m的值，%d用于打印十进制整数
 printf("Value of m : %d\n", m);

 // 打印空行和说明文字
 printf("\nNow ab is assigned with the address of m.\n");

 // 打印指针ab存储的地址（即m的地址）。
 printf("Address of pointer ab : %p\n", (void *)ab);

 // 打印指针ab指向的内容（即m的值），%i用于打印整数
 printf("Content of pointer ab : %i\n\n", *ab);

 // 修改变量m的值为34
 m = 34;

 // 打印说明文字和m的新值
 printf("The value of m assigned to %d now.\n", m);

 // 打印ab存储的地址（即m的地址）。
 // 正确应该是：(void *)ab，而不是(void *)&ab
 printf("Address of pointer ab : %p\n", (void *)&ab);

 // 打印指针ab指向的内容（即m的新值34）
 printf("Content of pointer ab : %i\n\n", *ab);

 // 通过指针ab修改其指向的值（即修改m的值为7）
 *ab = 7;

 // 打印说明文字和通过指针修改后的值
 printf("The pointer variable ab is assigned with the value %i\n", *ab);

 // 再次打印变量m的地址，应该与之前相同
 printf("Address of m : %p\n", (void *)&m);

 // 打印变量m的值，现在应该是7
 printf("Value of m : %d\n", m);

 return 0; // 程序正常结束
}