#include "graphics.h"
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
 char ch;
 int color;
} Pixel;

static Pixel display[HEIGHT][WIDTH];
static HANDLE hConsole;

int initConsole() {
 // 获取控制台句柄
 hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
 if (hConsole == INVALID_HANDLE_VALUE) {
  return 0; // 初始化失败
 }

 // 设置控制台窗口大小
 SMALL_RECT rect = { 0, 0, WIDTH - 1, HEIGHT - 1 };
 if (!SetConsoleWindowInfo(hConsole, TRUE, &rect)) {
  return 0;
 }

 COORD size = { WIDTH, HEIGHT };
 if (!SetConsoleScreenBufferSize(hConsole, size)) {
  return 0;
 }

 // 隐藏光标
 CONSOLE_CURSOR_INFO cursorInfo;
 cursorInfo.dwSize = 1;
 cursorInfo.bVisible = FALSE;
 SetConsoleCursorInfo(hConsole, &cursorInfo);

 clearDisplay();
 return 1; // 初始化成功
}

void clearDisplay() {
 for (int y = 0; y < HEIGHT; y++) {
  for (int x = 0; x < WIDTH; x++) {
   display[y][x].ch = ' ';
   display[y][x].color = BLACK;
  }
 }
}

void setPixel(int x, int y, char ch, int color) {
 if (x >= 0 && x < WIDTH && y >= 0 && y < HEIGHT) {
  display[y][x].ch = ch;
  display[y][x].color = color;
 }
}

void renderAll() {
 COORD coord = { 0, 0 };
 SetConsoleCursorPosition(hConsole, coord);

 for (int y = 0; y < HEIGHT; y++) {
  for (int x = 0; x < WIDTH; x++) {
   SetConsoleTextAttribute(hConsole, display[y][x].color);
   putchar(display[y][x].ch);
  }
  putchar('\n');
 }
 SetConsoleTextAttribute(hConsole, WHITE); // 重置颜色
}

void showWelcomeScreen() {
 clearDisplay();

 const char* welcomeText = "春节烟花模拟程序";
 int textX = (WIDTH - (int)strlen(welcomeText)) / 2;
 int textY = HEIGHT / 2 - 2;

 for (int i = 0; i < (int)strlen(welcomeText); i++) {
  setPixel(textX + i, textY, welcomeText[i], BRIGHT_RED);
 }

 const char* prompt = "按任意键开始...";
 int promptX = (WIDTH - (int)strlen(prompt)) / 2;
 int promptY = HEIGHT / 2 + 2;

 for (int i = 0; i < (int)strlen(prompt); i++) {
  setPixel(promptX + i, promptY, prompt[i], BRIGHT_YELLOW);
 }

 renderAll();
}

void showSpringFestivalGreetings() {
 clearDisplay();

 const char* greetings[] = {
     "新春快乐！",
     "恭喜发财！",
     "万事如意！",
     "阖家幸福！"
 };

 int numLines = sizeof(greetings) / sizeof(greetings[0]);

 for (int i = 0; i < numLines; i++) {
  int textX = (WIDTH - (int)strlen(greetings[i])) / 2;
  int textY = HEIGHT / 2 - (numLines / 2) + i;

  for (int j = 0; j < (int)strlen(greetings[i]); j++) {
   setPixel(textX + j, textY, greetings[i][j], BRIGHT_YELLOW);
  }
 }

 renderAll();
}