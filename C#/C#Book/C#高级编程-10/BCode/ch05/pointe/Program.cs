unsafe
{
 int x = 10;
 int* pX, pY;

 Console.WriteLine($"x 的原始值 = {x}");

 pX = &x;
 pY = pX;
 *pY = 20;

ulong y = (ulong)pX;


 Console.WriteLine($"获取 pY 的值 {*pX}");
 Console.WriteLine($"pX 的地址 {(ulong)pX}");
}
