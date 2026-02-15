#include "audio.h"
#include <windows.h>
#include <mmsystem.h>
#pragma comment(lib, "winmm.lib")  // 添加这一行

int musicPlaying = 0;
clock_t musicStartTime = 0;

void playBackgroundMusic() {
 if (PlaySound(TEXT("music.wav"), NULL, SND_FILENAME | SND_ASYNC)) {
  musicPlaying = 1;
 }
 else {
  Beep(523, 100); Beep(659, 100); Beep(784, 100);
  musicPlaying = 1;
 }
 musicStartTime = clock();
}

void stopBackgroundMusic() {
 PlaySound(NULL, NULL, SND_PURGE);
 musicPlaying = 0;
}

void toggleMusic() {
 if (musicPlaying) {
  stopBackgroundMusic();
 }
 else {
  playBackgroundMusic();
 }
}