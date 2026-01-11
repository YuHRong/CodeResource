#include<stdio.h>

int max_of_three(int a, int b, int c){
if (a >= b && a >= c)
{
    return a;
}
else if(b >= a && b >= c)
{
    return b;
}
else
{
    return c;
}
}

int main(void){
    int a = 10, b = 20, c = 15;
    int max = max_of_three(a, b, c);
    printf("The maximum value is: %d\n", max);

    return 0;
}