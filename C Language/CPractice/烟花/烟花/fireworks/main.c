#include "graphics.h"
#include "fireworks.h"
#include "objects.h"
#include "audio.h"  // 包含音频头文件
#include <conio.h>
#include <time.h>
#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

int main() {
 // 设置随机种子
 srand((unsigned int)time(NULL));

 initConsole();
 initFireworks();
 initObjects();

 printf("=== 春节烟花模拟程序 ===\n");
 printf("按 M 键切换音乐开关\n");
 printf("按任意键开始发射烟花...\n");

 // 自动播放背景音乐
 playBackgroundMusic();

 _getch();

 // 清屏
 system("cls");

 int running = 1;
 int frameCount = 0;
 int lastMusicState = musicPlaying;

 // 创建欢迎消息
 createMessage(30, 2, "春节快乐！");
 createMessage(28, 4, "烟花模拟演示");

 while (running && frameCount < 500) {
  clearDisplay();

  // 随机发射烟花
  if (rand() % 8 == 0 && getFireworkCount() < MAX_FIREWORKS) {
   int x = 15 + rand() % 50;
   launchFirework((float)x, (float)(HEIGHT - 3));
  }

  updateFireworks();
  updateObjects();

  renderFireworks();
  renderObjects();

  // 显示帧信息和音乐状态
  char info[80];
  char musicStatus[10];
  if (musicPlaying) {
   strcpy_s(musicStatus, 10, "音乐:开");
  }
  else {
   strcpy_s(musicStatus, 10, "音乐:关");
  }

  sprintf_s(info, 80, "帧:%d 烟花:%d %s (ESC退出 M切换音乐)",
   frameCount, getFireworkCount(), musicStatus);

  for (int i = 0; i < strlen(info) && i < WIDTH; i++) {
   setPixel(i, 0, info[i], 11); // 青色
  }

  // 底部提示
  char hint[] = "春节烟花模拟 - 带背景音乐";
  for (int i = 0; i < strlen(hint) && i < WIDTH; i++) {
   setPixel(i, HEIGHT - 1, hint[i], 13); // 紫色
  }

  renderAll();
  frameCount++;

  // 键盘输入处理
  if (_kbhit()) {
   int key = _getch();
   switch (key) {
   case 27: // ESC键
    running = 0;
    break;
   case 'm':
   case 'M': // M键切换音乐
    toggleMusic();
    // 给用户反馈
    if (musicPlaying) {
     Beep(523, 100); // 开音乐提示音
    }
    else {
     Beep(262, 100); // 关音乐提示音
    }
    break;
   }
  }

  // 检查音乐状态变化
  if (musicPlaying != lastMusicState) {
   lastMusicState = musicPlaying;
   // 可以在这里添加状态变化的处理
  }

  Sleep(80);
 }

 // 停止音乐
 stopBackgroundMusic();

 // 播放结束音效
 Beep(659, 200);
 Beep(523, 300);

 // 结束信息
 system("cls");
 printf("=== 烟花演示结束 ===\n");
 printf("总共运行了 %d 帧\n", frameCount);
 printf("音乐播放时间: %.1f 秒\n",
  musicPlaying ? (double)(clock() - musicStartTime) / CLOCKS_PER_SEC : 0);
 printf("感谢使用！按任意键退出...\n");
 _getch();

 return 0;
}