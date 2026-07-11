/* // Write a C program to read an amount (integer value) and break the amount into the smallest possible number of bank notes.

#include <stdio.h>

int main()
{
 int one_note, two_note, five_note, ten_note, twty_note, fty_note, hun_note, amount;
 one_note = two_note = five_note = ten_note = twty_note = fty_note, hun_note = 0;

 printf("Input the amount:");
 scanf("%d", &amount);

 hun_note = amount / 100;
 fty_note = amount % 100 / 50;
 twty_note = amount % 50 / 20;
 ten_note = amount % 20 / 10;
 five_note = amount % 10 / 5;
 two_note = amount % 5 / 2;
 one_note = amount % 2;

 printf("There are: \n");
 printf("%d Note(s) of 100.00\n", hun_note);
 printf("%d Note(s) of 50.00\n", fty_note);
 printf("%d Note(s) of 20.00\n", twty_note);
 printf("%d Note(s) of 10.00\n", ten_note);
 printf("%d Note(s) of 5.00\n", five_note);
 printf("%d Note(s) of 2.00\n", two_note);
 printf("%d Note(s) of 1.00\n", one_note);

 return 0;
} */

// Write a C program to read an amount (integer value) and break the amount into the smallest possible number of bank notes.

#include <stdio.h>

int main()
{
 int amount, total = 0;

 printf("Input the amount:");
 scanf("%d", &amount);

 printf("There are: \n");

 total = amount / 100;
 printf("%d Note(s) of 100.00\n", total);

 amount = amount - (total * 100);
 total = amount / 50;
 printf("%d Note(s) of 50.00\n", total);

 amount = amount - (total * 50);
 total = amount / 20;
 printf("%d Note(s) of 20.00\n", total);

 amount = amount - (total * 20);
 total = amount / 10;
 printf("%d Note(s) of 10.00\n", total);

 amount = amount - (total * 10);
 total = amount / 5;
 printf("%d Note(s) of 5.00\n", total);

 amount = amount - (total * 5);
 total = amount / 2;
 printf("%d Note(s) of 2.00\n", total);

 amount = amount - (total * 2);
 total = amount / 1;
 printf("%d Note(s) of 1.00\n", total);

 return 0;
}