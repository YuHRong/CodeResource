#ifndef GRAPHICS_H
#define GRAPHICS_H

#define WIDTH 80
#define HEIGHT 24

// 颜色定义
enum Colors {
 BLACK = 0,
 BLUE = 1,
 GREEN = 2,
 CYAN = 3,
 RED = 4,
 MAGENTA = 5,
 YELLOW = 6,
 WHITE = 7,
 GRAY = 8,
 BRIGHT_BLUE = 9,
 BRIGHT_GREEN = 10,
 BRIGHT_CYAN = 11,
 BRIGHT_RED = 12,
 BRIGHT_MAGENTA = 13,
 BRIGHT_YELLOW = 14,
 BRIGHT_WHITE = 15
};

// 函数声明
int initConsole();  // 返回初始化是否成功
void clearDisplay();
void setPixel(int x, int y, char ch, int color);
void renderAll();
void showWelcomeScreen();
void showSpringFestivalGreetings();

#endif