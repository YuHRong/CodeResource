/* zippo1.c --  zippo的相关信息 */
#include<stdio.h>

int main(void)
{
 int zippo[4][2] = { {2, 4}, {6, 8}, {1, 3}, {5, 7} };

 printf("Zippo = %p,    zippo + 1 = %p\n", zippo, zippo + 1);
 printf("zippo[0] =%p, zippo[0+1] = %p\n", zippo[0], zippo[0] + 1);
 printf("*zippo = %p, *zippo +1 = %p\n", *zippo, *zippo + 1);
 printf("zippo[0][0] = %d\n", zippo[0][0]);
 printf("*zippo[0] = %d\n", *zippo[0]);
 printf("  **zippo = %d\n", **zippo);
 printf("zippo[2][1] = %d\n", zippo[2][1]);
 printf(" *(*(zippo + 2) + 1) = %d\n", *(*(zippo + 2) + 1));

 return 0;
}

/*下面列出了理解该表达式的思路:  
zippo             ←二维数组首元素的地址(每个元素都是内含两个int类型元素的一维数组)
zippo+2           ←二维数组的第3个元素(即一维数组)的地址
*(zippo+2)        ←二维数组的第3个元素(即一维数组)的首元素(一个int类型的值)地址
*(zippo+2) + 1    ←二维数组的第3个元素(即一维数组)的第2个元素(也是一个int类型的值)地址
*(*(zippo+2) + 1) ←二维数组的第3个一维数组元素的第2个int类型元素的值,即数组的第3行第2列的值(zippo[2][1])      
*/