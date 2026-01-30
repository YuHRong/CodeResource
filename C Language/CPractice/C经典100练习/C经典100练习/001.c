#include<stdio.h>

int main()
{
    int i, j, k;

    printf("\n");
for( i = 1; i < 5; i++) 
{  // 以下为三层循环
for(j = 1; j < 5; j++)
{
    for(k = 1; k < 5; k++)
    {  // 确保 i j k 互不相同
if(i != j && i != k && j != k)
{
    printf("%d, %d, %d\n", i, j, k);
}
    }
}
}
}