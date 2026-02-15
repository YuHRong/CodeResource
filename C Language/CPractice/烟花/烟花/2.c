#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
#include <mmsystem.h>
#include <math.h>
#include <string.h>

#pragma comment(lib, "winmm.lib")

// 控制台尺寸定义
#define WIDTH 80
#define HEIGHT 30
#define MAX_PARTICLES 800
#define MAX_FIREWORKS 25
#define MUSIC_DURATION 30482  // 音乐时长30.482秒
#define MAX_MESSAGES 10
#define MAX_FIRECRACKERS 50   // 最大鞭炮数量

// 丰富的颜色选项
#define COLOR_COUNT 16
static int availableColors[COLOR_COUNT] = {
    1,   // 蓝色
    2,   // 绿色
    3,   // 浅蓝色
    4,   // 红色
    5,   // 紫色
    6,   // 黄色
    9,   // 亮蓝色
    10,  // 亮绿色
    11,  // 亮浅蓝色
    12,  // 亮红色
    13,  // 亮紫色
    14,  // 亮黄色
    15,  // 亮白色
    16,  // 灰色
    23,  // 橙色
    31   // 亮白色
};

// 春节祝福语
static const char* springFestivalMessages[MAX_MESSAGES] = {
    "新春快乐！",
    "马年吉祥！",
    "万事如意！",
    "恭喜发财！",
    "阖家幸福！",
    "身体健康！",
    "学业进步！",
    "事业有成！",
    "心想事成！",
    "年年有余！"
};

// 粒子结构体
typedef struct {
 float x, y;      // 位置坐标
 float vx, vy;    // 速度向量
 int life;        // 生命周期
 int color;       // 颜色代码
 int trail;       // 是否为轨迹粒子
} Particle;

// 烟花结构体
typedef struct {
 float x, y;                     // 位置坐标
 int exploded;                   // 是否已爆炸
 int color;                      // 基础颜色
 Particle particles[MAX_PARTICLES]; // 粒子数组
 int particleCount;              // 粒子数量
 clock_t createTime;             // 创建时间
} Firework;

// 鞭炮结构体
typedef struct {
 float x, y;           // 位置坐标
 int exploded;         // 是否已爆炸
 int life;             // 生命周期
 int color;            // 颜色
 int active;           // 是否激活
 int sparkCount;       // 火花数量
 float sparks[20][2];  // 火花位置 [x, y]
} Firecracker;

// 祝福语结构体
typedef struct {
 char text[50];                  // 祝福文本
 int x, y;                       // 显示位置
 int color;                      // 颜色
 int life;                       // 显示时间
 int active;                     // 是否激活
} Message;

// 全局变量
static char display[HEIGHT][WIDTH];        // 显示缓冲区
static int colors[HEIGHT][WIDTH];          // 颜色缓冲区
static Firework fireworks[MAX_FIREWORKS];  // 烟花数组
static int fireworkCount = 0;              // 当前烟花数量
static int musicPlaying = 0;               // 音乐播放状态
static clock_t musicStartTime = 0;         // 音乐开始时间
static int programStarted = 0;             // 程序是否开始
static Message messages[5];                // 祝福语数组
static int messageCount = 0;               // 当前祝福语数量
static clock_t lastMessageTime = 0;        // 上次生成祝福语的时间
static Firecracker firecrackers[MAX_FIRECRACKERS]; // 鞭炮数组
static int firecrackerCount = 0;           // 当前鞭炮数量
static clock_t lastFirecrackerTime = 0;    // 上次生成鞭炮的时间

// 函数声明
static void clearDisplay(void);
static void updateParticles(void);
static void renderDisplay(void);
static void createFirework(float x, float y, int color);
static void explodeFirework(Firework* fw);
static void playBackgroundMusic(void);
static void stopBackgroundMusic(void);
static void toggleMusic(void);
static void showWelcomeScreen(void);
static void createMessage(const char* text, int x, int y, int color);
static void updateMessages(void);
static void showSpringFestivalGreetings(void);
static void createFirecracker(float x, float y);
static void explodeFirecracker(Firecracker* fc);
static void updateFirecrackers(void);
static void cleanupFireworks(void);

// 初始化控制台
static void initConsole(void) {
 system("cls");

 // 设置控制台窗口大小
 HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);

 // 设置控制台缓冲区大小
 COORD bufferSize = { WIDTH, HEIGHT + 10 };
 SetConsoleScreenBufferSize(hConsole, bufferSize);

 // 设置控制台窗口大小
 SMALL_RECT rect = { 0, 0, WIDTH - 1, HEIGHT - 1 };
 SetConsoleWindowInfo(hConsole, TRUE, &rect);

 // 隐藏光标
 CONSOLE_CURSOR_INFO cursorInfo;
 GetConsoleCursorInfo(hConsole, &cursorInfo);
 cursorInfo.bVisible = FALSE;
 SetConsoleCursorInfo(hConsole, &cursorInfo);
}

// 清空显示缓冲区
static void clearDisplay(void) {
 for (int y = 0; y < HEIGHT; y++) {
  for (int x = 0; x < WIDTH; x++) {
   display[y][x] = ' ';
   colors[y][x] = 7;  // 默认灰色
  }
 }
}

// 显示欢迎界面
static void showWelcomeScreen(void) {
 HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
 system("cls");

 SetConsoleTextAttribute(hConsole, 14); // 黄色
 printf("\n\n\n");
 printf("            ★★★★★★★★★★★★★★★★★★★★★★★★★\n");
 printf("            ★                                                  ★\n");
 printf("            ★             新春烟花表演程序                    ★\n");
 printf("            ★                                                  ★\n");
 printf("            ★★★★★★★★★★★★★★★★★★★★★★★★★\n\n");

 SetConsoleTextAttribute(hConsole, 11); // 浅蓝色
 printf("                马年吉祥！欢迎观看烟花表演！\n\n");

 SetConsoleTextAttribute(hConsole, 15); // 白色
 printf("                       点击开始...\n");  // 移除了emoji

 SetConsoleTextAttribute(hConsole, 7); // 恢复默认颜色
}

// 创建新烟花 - 修复颜色问题
static void createFirework(float x, float y, int color) {
 if (fireworkCount >= MAX_FIREWORKS) return;

 Firework* fw = &fireworks[fireworkCount++];
 fw->x = x;
 fw->y = y;
 fw->exploded = 0;

 // 从颜色数组中随机选择颜色
 fw->color = availableColors[rand() % COLOR_COUNT];
 fw->particleCount = 0;
 fw->createTime = clock();

 // 创建上升轨迹粒子
 float speed = (float)(rand() % 5 + 5) / 10.0f;
 float angle = (float)(rand() % 360) * 3.14159f / 180.0f;

 for (int i = 0; i < 12; i++) {
  if (fw->particleCount >= MAX_PARTICLES) break;

  Particle* p = &fw->particles[fw->particleCount++];
  p->x = fw->x;
  p->y = fw->y;
  p->vx = cosf(angle) * speed * 0.5f;
  p->vy = -speed * (0.8f + (float)(rand() % 20) / 100.0f);
  p->life = 40 + rand() % 20;
  p->color = fw->color;  // 使用烟花的颜色
  p->trail = 1;  // 标记为轨迹粒子
 }
}

// 烟花爆炸效果 - 修复颜色显示问题
static void explodeFirework(Firework* fw) {
 fw->exploded = 1;

 // 根据音乐进度调整爆炸强度
 int numParticles = 80 + rand() % 70;
 if (musicStartTime > 0) {
  clock_t currentTime = clock();
  int elapsed = (int)((currentTime - musicStartTime) * 1000 / CLOCKS_PER_SEC);
  if (elapsed > MUSIC_DURATION * 70 / 100) {
   numParticles = 120 + rand() % 80;  // 后期爆炸更强烈
  }
 }

 // 创建多彩爆炸粒子 - 修复颜色分配
 for (int i = 0; i < numParticles; i++) {
  if (fw->particleCount >= MAX_PARTICLES) break;

  Particle* p = &fw->particles[fw->particleCount++];
  p->x = fw->x;
  p->y = fw->y;

  // 随机角度和速度
  float angle = (float)(rand() % 360) * 3.14159f / 180.0f;
  float speed = (float)(rand() % 15 + 8) / 10.0f;

  p->vx = cosf(angle) * speed;
  p->vy = sinf(angle) * speed;
  p->life = 70 + rand() % 50;

  // 多彩效果：使用不同的颜色分配策略
  if (i % 3 == 0) {
   p->color = fw->color;  // 使用烟花原色
  }
  else if (i % 3 == 1) {
   // 使用互补色或相近色
   int newColor = availableColors[(rand() % COLOR_COUNT)];
   p->color = newColor;
  }
  else {
   // 随机选择鲜艳颜色
   p->color = availableColors[rand() % COLOR_COUNT];
  }

  p->trail = 0;  // 爆炸粒子没有轨迹
 }
}

// 创建鞭炮
static void createFirecracker(float x, float y) {
 if (firecrackerCount >= MAX_FIRECRACKERS) return;

 Firecracker* fc = &firecrackers[firecrackerCount++];
 fc->x = x;
 fc->y = y;
 fc->exploded = 0;
 fc->life = 30 + rand() % 20;
 fc->color = 12;  // 红色
 fc->active = 1;
 fc->sparkCount = 0;
}

// 鞭炮爆炸效果
static void explodeFirecracker(Firecracker* fc) {
 fc->exploded = 1;
 fc->life = 15;  // 爆炸后显示时间

 // 创建爆炸火花
 fc->sparkCount = 15 + rand() % 10;
 for (int i = 0; i < fc->sparkCount; i++) {
  float angle = (float)(rand() % 360) * 3.14159f / 180.0f;
  float distance = (float)(rand() % 8 + 3) / 2.0f;
  fc->sparks[i][0] = cosf(angle) * distance;  // x偏移
  fc->sparks[i][1] = sinf(angle) * distance;  // y偏移
 }
}

// 更新鞭炮状态 - 这个函数已经包含了渲染逻辑
static void updateFirecrackers(void) {
 for (int i = 0; i < firecrackerCount; i++) {
  Firecracker* fc = &firecrackers[i];
  if (!fc->active) continue;

  fc->life--;

  if (fc->life <= 0) {
   fc->active = 0;
   continue;
  }

  // 在生命周期的一半时爆炸
  if (!fc->exploded && fc->life < 15) {
   explodeFirecracker(fc);
  }

  // 绘制鞭炮 - 这里已经包含了渲染逻辑
  int px = (int)fc->x;
  int py = (int)fc->y;

  if (px >= 0 && px < WIDTH && py >= 0 && py < HEIGHT) {
   if (!fc->exploded) {
    // 未爆炸的鞭炮
    display[py][px] = '|';
    colors[py][px] = fc->color;

    // 鞭炮引信
    if (py > 0) {
     display[py - 1][px] = '\'';
     colors[py - 1][px] = 6;  // 黄色引信
    }
   }
   else {
    // 爆炸效果
    display[py][px] = '*';
    colors[py][px] = 14;  // 黄色爆炸中心

    // 绘制火花
    for (int j = 0; j < fc->sparkCount; j++) {
     int sparkX = px + (int)fc->sparks[j][0];
     int sparkY = py + (int)fc->sparks[j][1];

     if (sparkX >= 0 && sparkX < WIDTH && sparkY >= 0 && sparkY < HEIGHT) {
      display[sparkY][sparkX] = '.';
      colors[sparkY][sparkX] = (rand() % 2) ? 12 : 14;  // 红色或黄色火花
     }
    }
   }
  }
 }
}

// 创建祝福语
static void createMessage(const char* text, int x, int y, int color) {
 if (messageCount >= 5) return;

 Message* msg = &messages[messageCount++];
 strncpy(msg->text, text, sizeof(msg->text) - 1);
 msg->text[sizeof(msg->text) - 1] = '\0';
 msg->x = x;
 msg->y = y;
 msg->color = color;
 msg->life = 100 + rand() % 50;  // 显示时间
 msg->active = 1;
}

// 更新祝福语状态
static void updateMessages(void) {
 for (int i = 0; i < messageCount; i++) {
  if (messages[i].active) {
   messages[i].life--;
   if (messages[i].life <= 0) {
    messages[i].active = 0;
   }

   // 在显示缓冲区中绘制祝福语
   const char* text = messages[i].text;
   int len = (int)strlen(text);  // 修复类型转换警告
   int x = messages[i].x;
   int y = messages[i].y;

   for (int j = 0; j < len && x + j < WIDTH; j++) {
    if (x + j >= 0) {
     display[y][x + j] = text[j];
     colors[y][x + j] = messages[i].color;
    }
   }
  }
 }
}

// 显示春节祝福语
static void showSpringFestivalGreetings(void) {
 clock_t currentTime = clock();

 // 每3-5秒随机生成一个祝福语
 if (currentTime - lastMessageTime > (CLOCKS_PER_SEC * (3 + rand() % 3))) {
  lastMessageTime = currentTime;

  const char* message = springFestivalMessages[rand() % MAX_MESSAGES];
  int x = rand() % (WIDTH - 20);  // 随机水平位置
  int y = rand() % 5 + 2;         // 顶部区域显示
  int color = availableColors[rand() % COLOR_COUNT];

  createMessage(message, x, y, color);
 }
}

// 更新粒子状态 - 修复颜色显示
static void updateParticles(void) {
 for (int i = 0; i < fireworkCount; i++) {
  Firework* fw = &fireworks[i];

  for (int j = 0; j < fw->particleCount; j++) {
   Particle* p = &fw->particles[j];

   if (p->life <= 0) continue;

   // 更新位置
   p->x += p->vx;
   p->y += p->vy;

   // 应用重力
   float gravity = 0.05f;
   if (musicStartTime > 0) {
    clock_t currentTime = clock();
    int elapsed = (int)((currentTime - musicStartTime) * 1000 / CLOCKS_PER_SEC);
    if (elapsed > MUSIC_DURATION * 60 / 100) {
     gravity = 0.03f;  // 后期重力减小，粒子飘得更久
    }
   }

   if (!fw->exploded) {
    p->vy += 0.02f;  // 上升阶段的重力
   }
   else {
    p->vy += gravity;  // 爆炸后的重力

    // 生命周期后期颜色变化效果
    if (p->life < 20) {
     // 淡出效果：颜色变亮
     int baseColor = p->color;
     if (baseColor <= 8 && baseColor > 0) {
      p->color = baseColor + 8;
     }
    }
   }

   p->life--;

   // 将粒子绘制到缓冲区
   int px = (int)p->x;
   int py = (int)p->y;

   if (px >= 0 && px < WIDTH && py >= 0 && py < HEIGHT) {
    if (p->trail) {
     display[py][px] = '*';  // 轨迹粒子用星号
    }
    else {
     display[py][px] = '.';  // 爆炸粒子用点号
    }
    colors[py][px] = p->color;
   }

   // 检查是否需要爆炸（上升阶段且速度接近0）
   if (!fw->exploded && p->vy >= 0 && p->life < 15) {
    explodeFirework(fw);
    break;
   }
  }
 }
}

// 渲染显示到控制台
static void renderDisplay(void) {
 HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
 COORD coord = { 0, 0 };

 // 设置光标位置到左上角
 SetConsoleCursorPosition(hConsole, coord);

 for (int y = 0; y < HEIGHT; y++) {
  for (int x = 0; x < WIDTH; x++) {
   // 设置颜色
   SetConsoleTextAttribute(hConsole, colors[y][x]);
   putchar(display[y][x]);
  }
  putchar('\n');
 }

 // 显示祝福语和状态
 SetConsoleTextAttribute(hConsole, 14);  // 黄色
 printf("马年吉祥！新春快乐！");

 // 显示鞭炮区域标识
 SetConsoleTextAttribute(hConsole, 12);  // 红色
 printf(" [鞭炮燃放区]");

 SetConsoleTextAttribute(hConsole, 7);  // 恢复默认颜色
}

// 播放背景音乐
static void playBackgroundMusic(void) {
 // 尝试播放音乐文件
 wchar_t wpath[MAX_PATH];
 MultiByteToWideChar(CP_UTF8, 0, "music.wav", -1, wpath, MAX_PATH);

 if (PlaySound(wpath, NULL, SND_FILENAME | SND_ASYNC)) {
  musicPlaying = 1;
  musicStartTime = clock();
  return;
 }

 // 如果音乐文件播放失败，使用系统声音作为备选
 PlaySound(TEXT("SystemExclamation"), NULL, SND_ALIAS | SND_ASYNC);
 musicPlaying = 1;
 musicStartTime = clock();
}

// 停止背景音乐
static void stopBackgroundMusic(void) {
 PlaySound(NULL, NULL, SND_ASYNC);
 musicPlaying = 0;
}

// 切换音乐播放状态
static void toggleMusic(void) {
 if (musicPlaying) {
  stopBackgroundMusic();
 }
 else {
  playBackgroundMusic();
 }
}

// 清理过期烟花和祝福语
static void cleanupFireworks(void) {
 int writeIndex = 0;

 for (int i = 0; i < fireworkCount; i++) {
  Firework* fw = &fireworks[i];
  int hasLiveParticles = 0;

  // 检查是否有存活的粒子
  for (int j = 0; j < fw->particleCount; j++) {
   if (fw->particles[j].life > 0) {
    hasLiveParticles = 1;
    break;
   }
  }

  if (hasLiveParticles) {
   // 保留这个烟花
   if (writeIndex != i) {
    fireworks[writeIndex] = fireworks[i];
   }
   writeIndex++;
  }
 }

 fireworkCount = writeIndex;

 // 清理过期的祝福语
 int msgWriteIndex = 0;
 for (int i = 0; i < messageCount; i++) {
  if (messages[i].active) {
   if (msgWriteIndex != i) {
    messages[msgWriteIndex] = messages[i];
   }
   msgWriteIndex++;
  }
 }
 messageCount = msgWriteIndex;

 // 清理过期的鞭炮
 int fcWriteIndex = 0;
 for (int i = 0; i < firecrackerCount; i++) {
  if (firecrackers[i].active) {
   if (fcWriteIndex != i) {
    firecrackers[fcWriteIndex] = firecrackers[i];
   }
   fcWriteIndex++;
  }
 }
 firecrackerCount = fcWriteIndex;
}

// 主函数
int main(void) {
 // 初始化随机种子
 srand((unsigned int)time(NULL));

 // 初始化控制台
 initConsole();

 // 显示欢迎界面
 showWelcomeScreen();

 // 等待用户按键开始
 int ch = _getch();  // 修复返回值忽略警告
 (void)ch;           // 消除未使用变量警告
 programStarted = 1;

 // 清屏并开始表演
 system("cls");

 // 自动开始播放音乐
 playBackgroundMusic();

 // 初始化祝福语
 lastMessageTime = clock();
 lastFirecrackerTime = clock();

 // 主循环
 while (1) {
  // 处理键盘输入
  if (_kbhit()) {
   int key = _getch();
   if (key == 27) {  // ESC键退出
    break;
   }
   else if (key == 'm' || key == 'M') {  // M键切换音乐
    toggleMusic();
   }
  }

  // 清空显示
  clearDisplay();

  // 随机生成新烟花
  if (fireworkCount < MAX_FIREWORKS / 2) {
   if (rand() % 20 == 0) {  // 5%的概率生成新烟花
    float x = (float)(rand() % (WIDTH - 10) + 5);
    createFirework(x, (float)(HEIGHT - 2), 0);
   }
  }

  // 随机生成鞭炮（在底部区域）
  clock_t currentTime = clock();
  if (currentTime - lastFirecrackerTime > (CLOCKS_PER_SEC * (1 + rand() % 2))) {
   lastFirecrackerTime = currentTime;
   if (firecrackerCount < MAX_FIRECRACKERS / 2) {
    float x = (float)(rand() % (WIDTH - 5) + 2);
    createFirecracker(x, (float)(HEIGHT - 3));  // 在底部区域创建鞭炮
   }
  }

  // 更新粒子系统
  updateParticles();

  // 更新鞭炮系统（这个函数已经包含了渲染逻辑）
  updateFirecrackers();

  // 显示春节祝福语
  showSpringFestivalGreetings();
  updateMessages();

  // 渲染显示
  renderDisplay();

  // 清理过期烟花和祝福语
  cleanupFireworks();

  // 控制帧率
  Sleep(30);
 }

 // 程序结束前停止音乐
 stopBackgroundMusic();

 // 恢复控制台设置
 system("cls");
 printf("烟花表演结束！感谢观看！马年吉祥！\n");

 return 0;
}