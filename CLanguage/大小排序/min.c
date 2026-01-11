#include<stdio.h>

int main(void){
    int a = 10, b = 20, c = 15;
    int min = (a<b )?((a < c)? a : c):((b < c)? b : c);
printf("The minimum value is: %d\n", min);
    return 0;
}