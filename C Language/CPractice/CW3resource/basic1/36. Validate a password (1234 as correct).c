// Write a C program to read a password until it is valid. For wrong password print "Incorrect password" and for correct password print, "Correct password" and quit the program. The correct password is 1234.

#include <stdio.h>

int main()
{
 int n;
 int password = 1234;

 do
 {
  printf("\nPlease enter password.\n");
  scanf("%d", &n);

  if (n == password)
   printf("Correct password.\n");
  else
   printf("Incorrect password, please re-enter\n");
 } while (n != password);

 printf("Bye.\n");

 return 0;
}