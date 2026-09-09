// Write a C program that reads 5 numbers and sums all odd values between them.

#include <stdio.h>
#include <string.h>

int main()
{
    int n[10];
    int i, count, total = 0;
    const char *number[] = {
        "first", "second", "third", "four", "fifth", "sex", "seven"};

    printf("Input need count numbers: ");
    scanf("%d", &count);

    printf("Input the %d numbers\n", count);

    for (i = 0; i < count; i++)
    {
        printf("Input %s number: ", number[i]);
        scanf("%d", &n[i]);

        if (n[i] % 2 != 0)
            total += n[i];
    }

    printf("Sum of all odd values: %d", total);

    return 0;
}