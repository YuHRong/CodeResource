#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
    int n, i;
    long double factorial = 1.0f;

    printf("Enter a positive integer: ");
    scanf("%d", &n);

    for (i = 1; i < n; i++) {
        factorial *= i;
    }

    printf("Factorial of %d: %.2f", n, factorial);

    return 0;
}
