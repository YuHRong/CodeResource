# 整数,整数是不带小数点的正整数，可以是正数也可以是负数：
my_int_1 = 56
my_int_2 = 12
print(type(my_int_1))  # <class 'int'>
print(type(my_int_2))  # <class 'int'>

## 整数加法运算
sum_result = my_int_1 + my_int_2
print("整数加法运算结果:", sum_result)  # 68

## 整数减法运算
sub_result = my_int_1 - my_int_2
print("整数减法运算结果:", sub_result)  # 44

## 整数乘法运算
mul_result = my_int_1 * my_int_2
print("整数乘法运算结果:", mul_result)  # 672

## 整数除法运算
div_result = my_int_1 / my_int_2
print("整数除法运算结果:", div_result)  # 4.666666666666667


# 浮点数,浮点数是带有小数点的数字，可以表示更精确的数值：
my_float_1 = 12.0
my_float_2 = 4.9
print(type(my_float_1))  # <class 'float'>
print(type(my_float_2))  # <class 'float'>

## 浮点数加法运算
float_sum_result = my_float_1 + my_float_2
print("浮点数加法运算结果:", float_sum_result)  # 16.9

## 浮点数减法运算
float_sub_result = my_float_1 - my_float_2
print("浮点数减法运算结果:", float_sub_result)  # 7.1

## 浮点数乘法运算
float_mul_result = my_float_1 * my_float_2
print("浮点数乘法运算结果:", float_mul_result)  # 58.8

## 浮点数除法运算
float_div_result = my_float_1 / my_float_2
print("浮点数除法运算结果:", float_div_result)  # 2.4489795918367347

## 如果将一个整数和一个浮点数相加，结果会自动转换为浮点数：
mixed_sum_result = my_int_1 + my_float_2
print("整数与浮点数相加结果:", mixed_sum_result)  # 60
print("结果类型:", type(mixed_sum_result))  # <class 'float'>

## 其他基本算术运算，例如减法、乘法和除法，也是如此。如果混合使用整数和浮点数，Python 将返回浮点数作为结果。
print("整数与浮点数相加结果类型:", type(mixed_sum_result))  # <class 'float'>
print("整数与浮点数相加结果:", mixed_sum_result)  # 60.9
print("整数与浮点数相减结果:", my_int_1 - my_float_2)  # 51.1
print("整数与浮点数相乘结果:", my_int_1 * my_float_2)  # 274.4
print("整数与浮点数相除结果:", my_int_1 / my_float_2)  # 11.428571428571429

# 总结:
## 整数和浮点数是 Python 中的两种基本数值类型。
## 整数用于表示没有小数部分的数字，而浮点数用于表示带有小数部分的数字。
## 它们都支持基本的算术运算，如加法、减法、乘法和除法。
print("整数与浮点数相加结果类型:", type(mixed_sum_result))  # <class 'float'>
print("整数与浮点数相加结果:", mixed_sum_result)  # 60
print("整数与浮点数相减结果:", my_int_1 - my_float_2)  # 51.1
print("整数与浮点数相乘结果:", my_int_1 * my_float_2)  # 274.4
print("整数与浮点数相除结果:", my_int_1 / my_float_2)  # 11.428571428571429


# 取模运算符（%）: 取模运算符用于计算两个数相除后的余数。
mod_result = my_int_1 % my_int_2
print("取模运算结果:", mod_result)  # 8，因为56除以12的商是4，余数是8
mod_float_result = my_float_1 % my_float_2
print("浮点数取模运算结果:", mod_float_result)  # 2.2，因为12.0除以4.9的商是2，余数是2.2

## 向下取整运算是将两个数相除，并返回小于或等于结果的最大整数。这可以通过双斜杠运算符 (//) 来实现。
floor_div_result = my_int_1 // my_int_2
print("向下取整运算结果:", floor_div_result)  # 4，因为56除以12的商是4.666...，向下取整后是4
floor_div_float_result = my_float_1 // my_float_2
print("浮点数向下取整运算结果:", floor_div_float_result)  # 2.0，因为12.0除以4.9的商是2.448...，向下取整后是2.0


# 指数运算符（**）: 指数运算符用于计算一个数的幂。
exp_result = my_int_2 ** 2
print("指数运算结果:", exp_result)  # 144，因为12的2次方是144
exp_float_result = my_float_2 ** 3
print("浮点数指数运算结果:", exp_float_result)  # 117.649，因为4.9的3次方是117.649
# 总结:
## 取模运算符（%）用于计算两个数相除后的余数
## 向下取整运算符（//）用于计算两个数相除后向下取整的结果
## 指数运算符（**）用于计算一个数的幂


# Python 还提供了内置函数，可以将数值数据或字符串转换为整数或浮点数。
## float()函数返回一个由给定数字构造的浮点数：
my_int_1 = float(my_int_1)
print("转换为浮点数:", my_int_1)  # 56.0
print("类型:", type(my_int_1))  # <class 'float'>

## int()函数返回一个由给定数字或字符串构造的整数：
my_float_2 = int(my_float_2)
print("转换为整数:", my_float_2)  # 4
print("类型:", type(my_float_2))  # <class 'int'>
## 此外，您还可以使用相同的内置函数将字符串转换为浮点数或整数：
str_int_1 = "45"
str_float_1 = "23.67"
converted_int = int(str_int_1)
converted_float = float(str_float_1)
print("字符串转换为整数:", converted_int)  # 45
print("字符串转换为浮点数:", converted_float)  # 23.67
print("转换后类型:", type(converted_int))  # <class 'int'>
print("转换后类型:", type(converted_float))  # <class 'float'>

# 总结:
## float()函数用于将数值数据或字符串转换为浮点数
## int()函数用于将数值数据或字符串转换为整数


# 以下是 Python 提供的其他一些处理整数和浮点数的方法。
##round()：将数字四舍五入到指定的小数位数。默认情况下，此函数四舍五入到最接近的整数，并返回一个没有小数位的整数：rounded_value = round(5.67)
rounded_value = round(5.67)
rounded_value2 = round(5.6789, 2)
print("四舍五入结果（默认）:", rounded_value)  # 6
print("四舍五入结果（保留两位小数）:", rounded_value2)  # 5.68

##abs()：返回数字的绝对值。对于整数和浮点数均适用：absolute_value = abs(-10)
absolute_value = abs(-10)
absolute_value2 = abs(-5.67)
print("绝对值结果（整数）:", absolute_value)  # 10
print("绝对值结果（浮点数）:", absolute_value2)  # 5.67

##pow()：计算一个数的幂。此函数接受两个参数，第一个是底数，第二个是指数：power_value = pow(2, 3)
power_value = pow(2, 3)
power_value2 = pow(4, 0.5)
print("幂运算结果（整数）:", power_value)  # 8
print("幂运算结果（浮点数）:", power_value2)  # 2.0

# 总结:
## round()函数用于将数字四舍五入到指定的小数位数
## abs()函数用于返回数字的绝对值
## pow()函数用于计算一个数的幂