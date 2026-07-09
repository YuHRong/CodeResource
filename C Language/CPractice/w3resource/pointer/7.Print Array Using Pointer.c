// Write a program in C to store n elements in an array and print the elements using a pointer.
#include <stdio.h>

int main(void)
{
 int n, ar[50];
 int i;

 printf("Input the number of elements to store in the array :\n");
 scanf("%d", &n);

 printf(" Input %d number of elements in the array :\n", n);

 for (i = 0; i < n; i++)
 {
  printf("Element - %d : ", i);
  scanf("%d", ar + i);
 }

 printf(" The elements you entered are : \n");

 for (i = 0; i < n; i++)
 {
  printf(" element - %d : %d \n", i, *(ar + i));
 }

 return 0;
}
