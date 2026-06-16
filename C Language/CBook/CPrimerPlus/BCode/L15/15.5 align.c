
//  align.c -- 使用 _Alignof 和 _Alignas （C11） 
#include <stdio.h>

int main(void)
{
 double dx;
 char ca;
 char cx;
 double dz;
 char cb;
 //_ char Alignas(double) cz;
 __declspec(align(8)) char cz;  // 使用MSVC的对齐语法，8是double的对齐要求

 printf("char alignment:   %zd\n", _Alignof(char));
 printf("double alignment: %zd\n", _Alignof(double));
 printf("&dx: %p\n", &dx);
 printf("&ca: %p\n", &ca);
 printf("&cx: %p\n", &cx);
 printf("&dz: %p\n", &dz);
 printf("&cb: %p\n", &cb);
 printf("&cz: %p\n", &cz);

 return 0;
}
