/* stringf.c -- ×Ö·û´®¸ñÊ½ */
#include<stdio.h>
#define BLURB "Authentic imtation!"
int main(void) {
 printf("[%2s]\n", BLURB);
 printf("[%24s]\n", BLURB);
 printf("[%24.5s]\n", BLURB);
 printf("[%-24.5s]\n", BLURB);

 return 0;
}

/*
 The NAME family just may be $XXX.XX dollars richer!
printf("The %s family just may be $%.2f richer!\n",name,cash);
*/