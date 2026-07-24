/*
 ??   运算符用于为可空类型或引用类型提供一个兜底默认值  。当左侧不为 null   时返回左侧值，否则返回右侧值：
<表达式1> ?? <表达式2>
如果 <表达式1>  不为 null ，返回 <表达式1> ；
否则返回 <表达式2> 。
从 C# 8.0 起，还可以使用  ??= （空合并赋值运算符），仅当变量为  null  时才赋值：
int? x = null;

x ??= 10;    // x 为 null，赋值为 10
x ??= 20;   // x 已有值 10，不再赋值
*/

double? num1 = null;
double? num2 = 3.14157;
// ?? 提供默认值
double result1 = num1 ?? 5.34;   // num1 为 null → 返回 5.34
double result2 = num2 ?? 5.34;   // num2 有值   → 返回 3.14157

Console.WriteLine($"num1 ?? 5.34 = {result1}");   // 5.34
Console.WriteLine($"num2 ?? 5.34 = {result2}");   // 3.14157

                                                  // 链式使用：提供多个备选值
int? a = null;
int? b = null;
int? c = 42;
int value = a ?? b ?? c ?? 0;    // 依次尝试，最终得到 42

Console.WriteLine($"a ?? b ?? c ?? 0 = {value}"); // 42

