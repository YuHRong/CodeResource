#pragma once
#ifndef OBJECTS_H
#define OBJECTS_H

#include "fireworks.h"  // 包含宏定义和Firework结构体

typedef struct {
 float x, y;
 char text[50];
 int life;
 int color;
} Message;

// 使用extern声明（不定义）全局变量
extern Message messages[];
extern int messageCount;

// 函数声明
void initObjects();
void createMessage(float x, float y, const char* text);
void updateObjects();
void renderObjects();

#endif