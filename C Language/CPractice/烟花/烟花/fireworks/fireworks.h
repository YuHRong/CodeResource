#pragma once
#ifndef FIREWORKS_H
#define FIREWORKS_H

#define WIDTH 80
#define HEIGHT 25
#define MAX_FIREWORKS 10
#define MAX_PARTICLES 100
#define MAX_FIRECRACKERS 5
#define MAX_MESSAGES 5

typedef struct {
 float x, y;
 float vx, vy;
 int life;
 char symbol;
 int color;
} Particle;

typedef struct {
 float x, y;
 float vx, vy;
 int life;
 int state; // 0:上升, 1:爆炸
 int color;
 Particle particles[MAX_PARTICLES];
 int particleCount;
 int timer;
} Firework;

// 使用extern声明全局变量（告诉编译器变量在其他地方定义）
extern Firework fireworks[];
extern int fireworkCount;

// 函数声明
void initFireworks();
void launchFirework(float x, float y);
void updateFireworks();
void renderFireworks();
int getFireworkCount();

#endif