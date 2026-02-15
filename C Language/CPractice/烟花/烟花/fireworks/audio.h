#pragma once
#ifndef AUDIO_H
#define AUDIO_H

#include <time.h>

// ÒôÆµ×´Ì¬
extern int musicPlaying;
extern clock_t musicStartTime;

// ÒôÆµ¿ØÖÆº¯Êı
void playBackgroundMusic();
void stopBackgroundMusic();
void toggleMusic();

#endif