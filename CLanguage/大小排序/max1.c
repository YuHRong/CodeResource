#include<stdio.h>

int main(void) {
    int a = 10, b =20, c = 15;
    int max = (a > b)?((a > c)? a : c):((b > c)? b : c);
    printf("The maximum number is: %d\n", max);

return 0;
}