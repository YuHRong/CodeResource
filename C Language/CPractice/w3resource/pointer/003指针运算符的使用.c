// ��C���Ա�д������ʾʹ�õ�ַ��&����ַ����*����ֵַ���������
#include <stdio.h> // 包含标准输入输出头文件，提供printf、putchar等函�?

int main(void) // 主函数，程序入口点，void表示不接受任何参�?
{
 // 声明并初始化三个不同类型的变�?
 int m = 300;            // 声明整型变量m并初始化�?300
 double fx = 300.600006; // 声明双精度浮点型变量fx并初始化�?300.600006
 char cht = 'z';         // 声明字符型变量cht并初始化为字�?'z'

 // 声明并初始化三个指针变量，分别指向上述变�?
 int *m_ptr = &m;      // 声明整型指针m_ptr并初始化为m的地址
 double *fx_ptr = &fx; // 声明双精度浮点型指针fx_ptr并初始化为fx的地址
 char *cht_ptr = &cht; // 声明字符型指针cht_ptr并初始化为cht的地址

 // 打印程序标题和分隔线
 printf("pointer : Demonstrate the use of & and * operator :\n");
 printf("--------------------------------------------------------\n"); // 打印50个字符的分隔�?

 // 打印三个变量的�?
 printf("m = %d\n", m);     // 使用%d格式说明符打印整型变量m的�?
 printf("fx = %lf\n", fx);  // 使用%lf格式说明符打印双精度浮点型变量fx的�?
 printf("cht = %c\n", cht); // 使用%c格式说明符打印字符型变量cht的�?

 putchar('\n'); // 打印一个空行，使输出更清晰

 // 演示&运算符的使用
 printf("Using & operator : \n");
 printf("-----------------------\n"); // 打印23个字符的分隔�?

 // 使用&运算符获取变量的地址并打�?
 printf("address of m = %p\n", &m);     // 打印变量m的地址，缺�?(void*)转换
 printf("address of fx = %p\n", &fx);   // 打印变量fx的地址，缺�?(void*)转换
 printf("address of cht = %p\n", &cht); // 打印变量cht的地址，缺�?(void*)转换

 putchar('\n'); // 打印一个空�?

 // 演示&�?*运算符的组合使用
 printf("Using & and * operator : \n");
 printf("-----------------------------\n"); // 打印29个字符的分隔�?

 // 先使�?&获取地址，再使用*解引用获取该地址的�?
 printf("value at address of m = %d\n", *(&m));     // 获取m的地址，然后解引用得到m的�?
 printf("value at address of fx = %lf\n", *(&fx));  // 获取fx的地址，然后解引用得到fx的�?
 printf("value at address of cht = %c\n", *(&cht)); // 获取cht的地址，然后解引用得到cht的�?

 putchar('\n'); // 打印一个空�?

 // 演示仅使用指针变�?
 printf("Using only pointer variable : \n");
 printf("----------------------------------\n"); // 打印34个字符的分隔�?

 // 错误！第2行应该使用fx_ptr而不�?&fx_ptr
 printf("address of m = %p\n", (void *)m_ptr);     // 正确：使用指针变量m_ptr打印m的地址
 printf("address of fx = %p\n", &fx_ptr);          // 错误！这是打印指针变量fx_ptr本身的地址，而不是fx的地址
 printf("address of cht = %p\n", (void *)cht_ptr); // 正确：使用指针变量cht_ptr打印cht的地址

 putchar('\n'); // 打印一个空�?

 // 演示仅使用指针运算符
 printf("Using only pointer operator : \n");
 printf("----------------------------------\n"); // 打印34个字符的分隔�?

 // 使用指针变量配合*运算符获取�?
 printf("value at address of m = %d\n", *m_ptr);     // 通过指针m_ptr解引用获取m的�?
 printf("value at address of fx = %lf\n", *fx_ptr);  // 通过指针fx_ptr解引用获取fx的�?
 printf("value at address of cht = %c\n", *cht_ptr); // 通过指针cht_ptr解引用获取cht的�?

 return 0; // 程序正常结束，返�?0表示成功
}