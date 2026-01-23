#define DEBUG #define RELEASE #define DEMO VERSION #if DEMO VERSION && !DEBUG
#warning you are building a demo version #endif #if DEBUG && DEMO VERSION
#error you cannot build a debug demo version #endif
using System;

class Demo
{
public static void Main()
 {
  Console.WriteLine("Demo application")
 }
}