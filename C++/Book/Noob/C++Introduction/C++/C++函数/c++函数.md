# C++ 函数

| 函数名   | 说明                     |
| -------- | ------------------------ |
| strcat() | 连接两个字符串           |
| memcpy() | 用来复制内存到另一个位置 |

## math() 函数

返回两个数中的最大数

```c++
// 函数返回两个数中较大的那个数
int max(int num1, int num2) 
{
 // 局部变量声明
 int result ;

 if (num1 > num2)
  result = num1 ;
 else
  result = num2 ;

 return result; 
}
```

