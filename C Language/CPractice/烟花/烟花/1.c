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

// 全局变量
static char display[HEIGHT][WIDTH];        // 显示缓冲区
static int colors[HEIGHT][WIDTH];          // 颜色缓冲区
static Firework fireworks[MAX_FIREWORKS];  // 烟花数组
static int fireworkCount = 0;              // 当前烟花数量
static int musicPlaying = 0;               // 音乐播放状态
static clock_t musicStartTime = 0;         // 音乐开始时间

// 函数声明
static void clearDisplay();
static void updateParticles();
static void renderDisplay();
static void createFirework(float x, float y, int color);
static void explodeFirework(Firework* fw);
static void playBackgroundMusic();
static void stopBackgroundMusic();
static void toggleMusic();
static void showMusicProgress();

// 初始化控制台
static void initConsole() {
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
static void clearDisplay() {
 for (int y = 0; y < HEIGHT; y++) {
  for (int x = 0; x < WIDTH; x++) {
   display[y][x] = ' ';
   colors[y][x] = 7;  // 默认灰色
  }
 }
}

// 创建新烟花
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
  p->color = fw->color;
  p->trail = 1;  // 标记为轨迹粒子
 }
}

// 烟花爆炸效果
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

 // 创建多彩爆炸粒子
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

  // 多彩效果：随机选择颜色
  p->color = availableColors[rand() % COLOR_COUNT];
  p->trail = 0;  // 爆炸粒子没有轨迹
 }
}

// 更新粒子状态
static void updateParticles() {
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
     // 淡出效果：暗色变亮色，亮色变暗色
     int baseColor = p->color;
     if (baseColor <= 8) {
      p->color = baseColor + 8;
     }
     else if (baseColor > 8 && baseColor <= 15) {
      p->color = baseColor - 8;
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
static void renderDisplay() {
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

 // 显示音乐进度和控制信息
 SetConsoleTextAttribute(hConsole, 15);  // 亮白色
 showMusicProgress();
 printf("按 M 键切换音乐 | 按 ESC 键退出\n");
}

// 播放背景音乐
static void playBackgroundMusic() {
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
static void stopBackgroundMusic() {
 PlaySound(NULL, NULL, SND_ASYNC);
 musicPlaying = 0;
}

// 切换音乐播放状态
static void toggleMusic() {
 if (musicPlaying) {
  stopBackgroundMusic();
 }
 else {
  playBackgroundMusic();
 }
}

// 显示音乐进度
static void showMusicProgress() {
 if (musicStartTime > 0) {
  clock_t currentTime = clock();
  int elapsed = (int)((currentTime - musicStartTime) * 1000 / CLOCKS_PER_SEC);
  int totalSeconds = MUSIC_DURATION / 1000;
  int currentSeconds = elapsed / 1000;
  float progress = (float)elapsed / MUSIC_DURATION;

  printf("音乐进度: %d.%d秒 / %d.%d秒 [",
   currentSeconds, elapsed % 1000 / 100,
   totalSeconds, MUSIC_DURATION % 1000 / 100);

  // 进度条显示
  int barWidth = 30;
  int pos = (int)(barWidth * progress);
  for (int i = 0; i < barWidth; i++) {
   if (i < pos) {
    printf("=");
   }
   else if (i == pos) {
    printf(">");
   }
   else {
    printf(" ");
   }
  }
  printf("] %.1f%%", progress * 100);

  // 显示音乐状态
  if (musicPlaying) {
   printf(" ♫ 播放中");
  }
  else {
   printf(" ■ 已停止");
  }
 }
 else {
  printf("音乐状态: 未开始播放");
 }
 printf("\n");
}

// 清理过期烟花
static void cleanupFireworks() {
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
}

// 主函数
int main() {
 // 初始化随机种子
 srand((unsigned int)time(NULL));

 // 初始化控制台
 initConsole();

 printf("烟花表演开始！加载中...\n");

 // 自动开始播放音乐
 playBackgroundMusic();

 // 主循环
 while (1) {
  // 处理键盘输入
  if (_kbhit()) {
   int ch = _getch();
   if (ch == 27) {  // ESC键退出
    break;
   }
   else if (ch == 'm' || ch == 'M') {  // M键切换音乐
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

  // 更新粒子系统
  updateParticles();

  // 渲染显示
  renderDisplay();

  // 清理过期烟花
  cleanupFireworks();

  // 控制帧率
  Sleep(30);
 }

 // 程序结束前停止音乐
 stopBackgroundMusic();

 // 恢复控制台设置
 system("cls");
 printf("烟花表演结束！感谢观看！\n");

 return 0;
}