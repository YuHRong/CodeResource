/*程序清单16.12中使用了一些预定义宏和预定义标识符。注意，其中一些是C99新增的，所以不支持C99的编译器可能无法识别它们。如果使用GCC，必须设置-std=c99 或-std=c11 。 */
// predef.c -- 预定义宏和预定义标识符
#include <stdio.h>
void why_me();
int main()
{
 printf("The file is %s.\n", _ _FILE_ _);
 printf("The date is %s.\n", _ _DATE_ _);
 printf("The time is %s.\n", _ _TIME_ _);
 printf("The version is %ld.\n", _ _STDC_VERSION_ _);
 printf("This is line %d.\n", _ _LINE_ _);
 printf("This function is %s\n", _ _func_ _);
 why_me();
 return 0;
}
void why_me()
{
 printf("This function is %s\n", _ _func_ _);
 printf("This is line %d.\n", _ _LINE_ _);
}
