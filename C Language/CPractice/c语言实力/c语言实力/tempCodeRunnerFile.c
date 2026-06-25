// 瀛楃�︿覆澶嶅埗
// 浣跨敤 strcpy() 灏嗕竴涓�鍙橀噺鐨勫瓧绗︿覆澶嶅埗鍒板彟澶栦竴涓�鍙橀噺涓�銆�

#include <stdio.h>
#include <string.h>

int main(void)
{
 char str1[1000], str2[1000];

 memset(str2, '\0', sizeof(str2));
 strcpy(str1, "This is a string\n");
 strcpy(str2, str1);

 printf("鏈€缁堢殑鐩�鏍囧瓧绗︿覆锛� %s\n", str2);

 return 0;
}