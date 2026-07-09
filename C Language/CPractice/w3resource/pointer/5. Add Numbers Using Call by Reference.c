#include <stdio.h>

void num_add(int a, int b, int *result);

int main(void){
 int n1, n2, sum;

 printf("Input the first number: \n");
 scanf("%d", &n1);

 printf("Input the second number: \n");
scanf("%d", &n2);

 num_add(n1, n2, &sum);

 printf("the sum of %d and %d is %d\n", n1, n2, sum);

 return 0;
}

void num_add(int a, int b, int *result){
 *result  = (a + b);
}