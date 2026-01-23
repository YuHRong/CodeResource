using System;
class  Fact
{
 int x;
 public int GetFact()
 {
  float temp;
  int save = x;
  int a = 1;
  while (x > a)
  {
   a++;
   temp = this.x / a;
   x /= a;
   if ((float) x != temp)
   {
    return 1;
   }
  }
  swap(this.x, save);
  return save;
 }
}