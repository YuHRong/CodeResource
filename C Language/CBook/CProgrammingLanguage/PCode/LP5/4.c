#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
 int wph;

 printf("请输入风力（每小时）： ");
 scanf("%d", &wph);

 if (wph < 1) {
  printf("Calm\n");
 }
 else if (wph < 4) {
  printf("Light air\n");
 }
 else if (wph < 28) {
  printf("Breeze\n");
 }
 else if (wph < 48) {
  printf("Gale\n");
 }
 else if (wph < 64) {
  printf("Storm\n");
 }
 else {
  printf("Hurricane\n");
 }

 return 0;
}