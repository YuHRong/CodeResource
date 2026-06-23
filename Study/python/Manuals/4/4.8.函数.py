def fib(n):    # 打印小于 n 的斐波那契数列
 """Print a Fibonacci series less than n."""
 
 a, b = 0, 1
 
 while a < n:
  print(a, end=('\n'))
  a, b = b, a + b
 print()
 
# 调用函数
fib(2000)
# 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597

