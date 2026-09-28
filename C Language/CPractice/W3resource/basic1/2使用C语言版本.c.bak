// 写一个C程序，获取你正在使用的C版本。
#include <stdio.h>

int main(void)
{
// 检查 C 标准版本
#if defined(__STDC_VERSION__)
    #if __STDC_VERSION__ >= 202500L
        printf("We are using C2y (experimental next-gen C standard, __STDC_VERSION__ = %ldL)!\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 202311L
        printf("We are using C23! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 202000L
        printf("We are using C23 (early draft/preview)! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 201710L
        printf("We are using C18! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 201112L
        printf("We are using C11! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 199901L
        printf("We are using C99! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #elif __STDC_VERSION__ >= 199409L
        printf("We are using C95! (__STDC_VERSION__ = %ldL)\n", __STDC_VERSION__);
    #else
        printf("We are using C89/C90 (with __STDC_VERSION__ defined as %ldL)!\n", __STDC_VERSION__);
    #endif
#else
    // 在最原始的 C89/C90 标准中，__STDC_VERSION__ 宏尚未被定义
    printf("We are using C89/C90! (__STDC_VERSION__ is not defined)\n");
#endif

    return 0;
}