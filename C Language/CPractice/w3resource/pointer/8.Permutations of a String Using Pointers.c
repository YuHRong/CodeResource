/*Permutations of a String Using Pointers
 *Write a program in C to print all permutations of a given string using pointers.
 *Expected Output
 *The permutations of the string are :
 *abcd  abdc  acbd  acdb  adcb  adbc  bacd  badc  bcad  bcda  bdca  bdac  cbad  cbda  cabd  cadb  cdab  cdba
 * dbca  dbac  dcba  dcab  dacb  dabc */

#include <stdio.h>
#include <string.h>

void swap_chars(char *a, char *b);
void generate_permutations(char *ch, char *start_ptr, char *end_ptr);

int main(void)
{
 char str1[] = "abcd";
 int str_count = 0, i;

 while (str1[str_count])
 {
  str_count++;
 }
 // printf("%d\n", str_count);
 printf("The permutations of the string are:\n");
 generate_permutations(str1, str1, str1 + str_count - 1);
 printf("\n");

 return 0;
}

void swap_chars(char *a, char *b)
{
 char t = *a;
 *a = *b;
 *b = t;
}

void generate_permutations(char *ch, char *start_ptr, char *end_ptr)
{
 if (start_ptr == end_ptr)
 {
  printf("%s  ", ch);
 }
 else
 {
  for (char *i = start_ptr; i <= end_ptr; i++)
  {
   swap_chars(start_ptr, i);
   generate_permutations(ch, start_ptr + 1, end_ptr);
   swap_chars(start_ptr, i);
  }
 }
}