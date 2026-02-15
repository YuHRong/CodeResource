#include "objects.h"
#include "graphics.h"
#include <stdlib.h>
#include <math.h>
#include <string.h>

// 只定义objects模块自己的全局变量
Message messages[MAX_MESSAGES];
int messageCount = 0;

// 移除fireworkCount的定义，使用fireworks.h中声明的

void initObjects() {
 messageCount = 0;
}

void createMessage(float x, float y, const char* text) {
 if (messageCount >= MAX_MESSAGES) return;

 messages[messageCount].x = x;
 messages[messageCount].y = y;
 strncpy(messages[messageCount].text, text, 49);
 messages[messageCount].text[49] = '\0';
 messages[messageCount].life = 100;
 messages[messageCount].color = 14; // 黄色

 messageCount++;
}

void updateObjects() {
 // 更新消息生命周期
 for (int i = 0; i < messageCount; i++) {
  if (messages[i].life > 0) {
   messages[i].life--;
  }
 }
}

void renderObjects() {
 // 渲染消息
 for (int i = 0; i < messageCount; i++) {
  if (messages[i].life > 0) {
   int len = strlen(messages[i].text);
   for (int j = 0; j < len; j++) {
    int px = (int)messages[i].x + j;
    int py = (int)messages[i].y;
    if (px >= 0 && px < WIDTH && py >= 0 && py < HEIGHT) {
     setPixel(px, py, messages[i].text[j], messages[i].color);
    }
   }
  }
 }
}