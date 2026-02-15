#include "fireworks.h"
#include "graphics.h"
#include <stdlib.h>
#include <math.h>
#include <time.h>

// 移除重复的宏定义

Firework fireworks[MAX_FIREWORKS];
int fireworkCount = 0;

void initFireworks() {
 fireworkCount = 0;
 srand((unsigned int)time(NULL));
}

void launchFirework(float x, float y) {
 if (fireworkCount >= MAX_FIREWORKS) return;

 fireworks[fireworkCount].x = x;
 fireworks[fireworkCount].y = y;
 fireworks[fireworkCount].vx = (rand() % 3 - 1) * 0.5f;  // 添加f后缀
 fireworks[fireworkCount].vy = -(2 + rand() % 3);
 fireworks[fireworkCount].life = 100;
 fireworks[fireworkCount].state = 0;
 fireworks[fireworkCount].color = 1 + rand() % 15;
 fireworks[fireworkCount].particleCount = 0;
 fireworks[fireworkCount].timer = 0;  // 初始化timer

 fireworkCount++;
}

void updateFireworks() {
 for (int i = 0; i < fireworkCount; i++) {
  if (fireworks[i].state == 0) {  // 上升状态
   fireworks[i].x += fireworks[i].vx;
   fireworks[i].y += fireworks[i].vy;
   fireworks[i].vy += 0.1f;  // 重力

   fireworks[i].timer++;  // 使用timer成员

   // 随机爆炸或到达顶点爆炸
   if (fireworks[i].timer > 30 + rand() % 20 || fireworks[i].vy >= 0) {
    fireworks[i].state = 1;
    fireworks[i].timer = 0;

    // 创建爆炸粒子
    for (int j = 0; j < MAX_PARTICLES; j++) {
     float angle = (float)j / MAX_PARTICLES * 2 * 3.14159f;
     float speed = 1 + (rand() % 10) * 0.1f;

     fireworks[i].particles[j].x = fireworks[i].x;
     fireworks[i].particles[j].y = fireworks[i].y;
     fireworks[i].particles[j].vx = cos(angle) * speed;
     fireworks[i].particles[j].vy = sin(angle) * speed;
     fireworks[i].particles[j].life = 30 + rand() % 20;
     fireworks[i].particles[j].color = fireworks[i].color;
     fireworks[i].particles[j].symbol = "*";  // 设置符号
    }
    fireworks[i].particleCount = MAX_PARTICLES;
   }
  }
  else if (fireworks[i].state == 1) {  // 爆炸状态
   fireworks[i].timer++;

   // 更新粒子
   int activeParticles = 0;
   for (int j = 0; j < fireworks[i].particleCount; j++) {
    if (fireworks[i].particles[j].life > 0) {
     fireworks[i].particles[j].x += fireworks[i].particles[j].vx;
     fireworks[i].particles[j].y += fireworks[i].particles[j].vy;
     fireworks[i].particles[j].vy += 0.05f;  // 粒子重力
     fireworks[i].particles[j].life--;
     activeParticles++;
    }
   }

   if (activeParticles == 0 || fireworks[i].timer > 100) {
    fireworks[i].state = 2;
   }
  }
 }

 // 移除结束的烟花
 for (int i = fireworkCount - 1; i >= 0; i--) {
  if (fireworks[i].state == 2) {
   for (int j = i; j < fireworkCount - 1; j++) {
    fireworks[j] = fireworks[j + 1];
   }
   fireworkCount--;
  }
 }
}

void renderFireworks() {
 for (int i = 0; i < fireworkCount; i++) {
  if (fireworks[i].state == 0) {  // 上升轨迹
   int trailX = (int)fireworks[i].x;
   int trailY = (int)fireworks[i].y;
   if (trailX >= 0 && trailX < WIDTH && trailY >= 0 && trailY < HEIGHT) {
    setPixel(trailX, trailY, '|', fireworks[i].color);
   }
  }
  else if (fireworks[i].state == 1) {  // 爆炸粒子
   for (int j = 0; j < fireworks[i].particleCount; j++) {
    if (fireworks[i].particles[j].life > 0) {
     int px = (int)fireworks[i].particles[j].x;
     int py = (int)fireworks[i].particles[j].y;
     if (px >= 0 && px < WIDTH && py >= 0 && py < HEIGHT) {
      setPixel(px, py, fireworks[i].particles[j].symbol, fireworks[i].particles[j].color);
     }
    }
   }
  }
 }
}

int getFireworkCount() {
 return fireworkCount;
}