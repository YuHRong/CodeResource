#include<stdio.h>

int main(void)
{
 int i, j, * p, * q;
 p = &i;    // 把 i 的地址赋值给p
 q = p;    //把p 的内容(即i 的地址)复制给q, 效果是把q 指向了p 所指向的地方

 // 现在p 和 q 都指向了 i ,所以可以用对*p 或*q 赋新值的方法来改变i
 *p = 1;
 *q = 2;
 // 任意数量的指针变量都可以指向同一个对象
 printf("%d:%p\n", *p, *p);
 return 0;
}