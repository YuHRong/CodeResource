# 简介:
## Python 是一种通用编程语言，以其简洁易用而闻名。
## Python 被广泛应用于数据科学和机器学习、Web 开发、脚本编写和自动化、嵌入式系统和物联网等众多领域。
## python 官网: https://www.python.org/


# 变量:
            ## 首先申明变量名称，在给变量赋值，如: 
name = 'windows'
age = 25

## 变量命名规则: 
### 变量名只能以字母或下划线（_）开头，不能以数字开头。
### 变量名只能包含英文字母a-z或者数字1-9或者下划线(_)开头。
### 变量名区分大小写，如: 
age = 25   #小写字母
Age = 30     # 首字母大写
AGE = 27     # 三个字母都是大写

### 变量名不能为 python 保留关键字，如: 
### if.
# class.
# dif


### 若变量名中包含多个单词，使用_分隔，如: 
my_age = 28
my_name = 'john'


# 注释: 
## 使用警号表示单行注释。
'''
这是
一个
多行注释。
'''


# print()
# 将数字打印倒控制台，如: 
print('hello world!')     # hello world!


# 数字类型:
## python 不需要申明数据类型，他会根据赋值来判断变量类型。

## Integer(整数): 
### 不含小数点的数字。

## float(浮点数): 
### 带小数点的数字

## String(字符串): 
### 用引号括起来的字符序列。
### 包括双引号("")单引号('')，如: 
my_str1 = 'hello'
my_str2 = "hello"

## Boolean(布尔值): 
### 表示是(True)或否(False)

## Set(): 
### 一组无序的、独特的元素：，如: 
my_set_var = {7, 5, 8}
print('Set:', my_set_var) # Set: {7, 5, 8}

## Dictionary(词典): 
### 用花括号括起来的键值对集合,如: 
my_dictionary_var = {"name": "Alice", "age": 25}
print('Dictionary:', my_dictionary_var) # Dictionary: {'name': 'Alice', 'age': 25}

## Tuple(元组): 
### 一个不可变的有序集合，用圆括号括起来,如： 
my_tuple_var = (7, 5, 8)
print('Tuple:', my_tuple_var) # Tuple: (7, 5, 8)

## Range(范围): 
### 一个数字序列，常用于循环中：
my_range_var = range(5)
print(my_range_var) # range(0, 5)

## List(列表): 
### 支持不同数据类型的有序元素集合，如: 
my_list = [22, 'Hello world', 3.14, True]
print(my_list) # [22, 'Hello world', 3.14, True]

## None*():
### 表示没有值的特殊值，如: 
my_none_var = None
print('None:', my_none_var) # None: None



# 不可变和可变类型:
## Immutable Types(不可变类型):
### 这些类型一旦声明就不能更改，尽管您可以将它们的变量指向新的东西，这被称为重新分配。它们包括整数、浮点数、复数、布尔值、字符串、元组、范围和None

## Mutable Types(可变类型): 
### 一旦声明，这些类型就可以更改。您可以添加、删除或更新他们的项目。它们包括列表、集合和字典等集合类型。


## type()函数: 
### 要查看变量类型，可以使用 type()函数，用法: 
greeting = 'Hello there!'
age = 21
print(type(greeting)) # <class 'str'>
print(type(age)) # <class 'int'>

## isinstance()函数
### ：用于检查变量是否与特定数据类型匹配，用法: 
print(isinstance('Hello world', str)) # True
print(isinstance('John Doe', int)) # False


# 字符串处理: 
## 字符串是不可变的，这意味着字符串一旦创建就无法更改。在 Python 中，你可以使用单引号或双引号。建议选择一种规则并坚持使用，如: 
developer = 'Jessica'
city = 'Los Angeles'

## 从字符串中访问字符: 
### 可以使用方括号表示法从字符串中访问字符，如下所示：
my_str = "Hello world"
print(my_str[0])  # H
print(my_str[6])  # w
print(my_str[-1])  # d
print(my_str[-2]) # l

## 转义字符串: 
### ：如果字符串包含引号，可以使用反斜杠 (  \  ) 进行转义，例如：
msg = 'It\'s a sunny day'
quote = "She said, \"Hello!\""

## 字符串连接
### 要连接字符串，可以使用加号(+)如下运算符：
developer = 'Jessica'
print('My name is ' + developer + '.') # My name is Jessica.

### 另一种连接字符串的方法是使用 +=  运算符。它可以在同一步骤中执行连接和赋值操作，如下所示：
greeting = 'My name is '
developer = 'Jessica.'
greeting += developer
print(greeting) # My name is Jessica.

## f-strings
### 这是格式化字符串字面量的简称。
### 它允许您处理插值，还可以使用简洁易读的语法进行一些字符串拼接操作：
developer = 'Jessica'
greeting = f'My name is {developer}.'
print(greeting) # My name is Jessica.

## 字符串切片
### 这是指提取字符串的各个部分。以下是基本语法：
### str[start:stop:step]
### 起始位置表示提取操作的起始索引。终止位置表示切片操作的结束位置，该位置不包含起始索引。步长表示切片操作的增量间隔。以下是一些示例：
message = 'Python is fun!'
print(message[0:6])  # Python
print(message[7:])  # is fun!
print(message[::2])  # Pto sfn

## 获取字符串长度: 
### 使用 len() 函数来返回字符串中的字符数。
developer = 'Jessica'
print(len(developer)) # 7


# in 运算符: 
## ：此运算符返回一个布尔值，指定字符串中是否存在指定的字符：
my_str = 'Hello world'
print('Hello' in my_str)  # True
print('hey' in my_str)    # False
print('hi' in my_str)    # False
print('e' in my_str)  # True
print('f' in my_str)  # False



# 常用字符串方法: 
## str.upper()
### 此操作返回一个全部为大写的字符串
developer = 'Jessica'
print(developer.upper()) # JESSICA

## str.lower()
### 此操作返回一个转换为小写的字符串
developer = 'Jessica'
print(developer.lower()) # jessica

## str.strip()
### ：这将返回一个字符串的副本，其中删除了指定的开头和结尾字符（如果没有向该方法传递参数，则会删除开头和结尾的空格）。
greeting = '  hello world  '
trimmed_my_str = greeting.strip()
print(trimmed_my_str)  # 'hello world'

## str.replace()   
### ：这将返回一个新字符串，其中所有出现的旧字符串都被替换为新字符串。
greeting = 'hello world'
replaced_my_str = greeting.replace('hello', 'hi')
print(replaced_my_str)  # 'hi world'

## str.split()
### 此函数用于使用指定的分隔符将字符串拆分为列表。分隔符是一个字符串，用于指定拆分位置。
dashed_name = 'example-dashed-name'
split_words = dashed_name.split('-')
print(split_words)  # ['example', 'dashed', 'name']

## str.join()
### 此方法用于将可迭代对象的元素连接成一个带有分隔符的字符串。可迭代对象是元素的集合，可以像列表、字符串或元组一样进行循环遍历。
example_list = ['example', 'dashed', 'name']
joined_str = ' '.join(example_list)
print(joined_str)  # example dashed name

## str.startswith())
### 此方法返回一个布尔值，指示字符串是否以指定的前缀开头：
developer = 'Naomi'
result = developer.startswith('N')
print(result)  # True

## str.endswith()
### 此方法返回一个布尔值，指示字符串是否以指定的后缀结尾：
developer = 'Naomi'
result = developer.endswith('N')
print(result)  # False

## str.find()
### 返回子字符串首次出现的索引。如果未找到匹配项，则返回空值。如果没有找到，那么 -1 
developer = 'Naomi'

result = developer.find('N')
print(result)  # 0
city = 'Los Angeles'
print(city.find('New')) # -1

## str.count()
### 此方法统计子字符串在字符串中出现的次数：
city = 'Los Angeles'
print(city.count('e')) # 2

## str.capitalize()
### 这将返回一个新字符串，其中第一个字符大写，其余字符小写：
dessert = 'chocolate cake'
print(dessert.capitalize()) # Chocolate cake

## str.isupper()
### 字符串中是否为大写，返回True,否则返回False。
dessert = 'Chocolate cake'
print(dessert.isupper()) # False

## str.islower()
### 字符串中是否为小写，返回 True，否则返回 False。
dessert = 'chocolate cake'
print(dessert.islower()) # True

## str.title()
### 返回一个心字符串，每个单词首字母大写。
city = 'los angeles'
print(city.title()) # Los Angeles

## str.maketrans()
### 此方法用于创建一对一字符映射表，以便进行翻译。它通常与
### str.translate()
### 一起使用
trans_table = str.maketrans('abc', '123')
print(trans_table) # {97: 49, 98: 50, 99: 51}

result = 'abcabc'.translate(trans_table)
print(result)  # 123123


# 整数和浮点数的运算: 
## 基本数学运算: 
### 在 Python 中，可以对整数和浮点数进行基本数学运算，包括加法、减法、乘法和除法：
int_1 = 56

int_2 = 12

float_1 = 5.4

float_2 = 12.0
# Addition
print('Integer Addition:', int_1 + int_2) # Integer Addition: 68
print('Float Addition:', float_1 + float_2) # Float Addition: 17.4
# Subtraction
print('Int Subtraction:', int_1 - int_2) # Int Subtraction: 44
print('Float Subtraction:',  float_2 - float_1) # Float Subtraction: 6.6
# Multiplication
print('Int Multiplication:', int_1 * int_2) # Int Multiplication: 672
print('Float Multiplication:', float_2 * float_1) # Float Multiplication: 64.80000000000001
# Division
print('Int Division:', int_1 / int_2) # Int Division: 4.666666666666667
print('Float Division:', float_2 / float_1) # Float Division: 2.222222222222222

### 当你将一个浮点数和一个整数相加时，结果将转换为浮点数，如下：
int_1 = 56
float_1 = 5.4
print(int_1 + float_1) # 61.4

## 取模运算符%:
### 返回一个数除以另一个数的余数
int_1 = 56
int_2 = 12
print(int_1 % int_2) # 8

## 向下取整//:
### 此运算符用于将两个数相除，并将结果向下取整到最接近的整数：
int_1 = 56
int_2 = 12
print(int_1 // int_2) # 4

## 指数运算符**:
### 此运算符用于将一个数提升到另一个数的幂：
int_1 = 4
int_2 = 2
print(int_1 ** int_2) # 16

## float()
### 可以将整数转换为浮点数:
num = 4
print(float(num)) # 4.0

## int()
### 可以将浮点数转换为整数:
num = 4.0
print(int(num)) # 4

## round() 
### 用于将数字四舍五入到最接近的整数: 
num_1 = 3.4

num_2 = 7.7
print(round(num_1)) # 3
print(round(num_2)) # 8

## abs()
### 用于返回一个数的绝对值:
num = -13
print(abs(num)) # 13

## bin()
### ：用于将整数转换为其二进制表示形式（字符串）：
num = 56
print(bin(num))  # 0b111000

## oct()
### ：用于将整数转换为其八进制表示形式的字符串：
num = 56
print(oct(num))  # 0o70

## hex()
### ：用于将整数转换为其十六进制字符串表示形式：
num = 56
print(hex(num))  # 0x38

## pow()
### ：用于将一个数提升到另一个数的幂：
result = pow(2, 3) 
print(result)  # 8


# 增强型任务:
## ：增强赋值将二元运算与赋值操作结合在一个步骤中。它接受一个变量，对其应用一个运算并使用另一个值，然后将结果存储回同一个变量中。

## Addition assignment(附加任务)
my_var = 10
my_var += 5
print(my_var) # 15

## Subtraction assignment(减法运算)
count = 14
count -= 3
print(count) # 11

## Multiplication assignment(乘法赋值)
product = 65
product *= 7
print(product) # 455

## Division assignment(积分分配)
price = 100
price /= 4
print(price) # 25.0

## Floor Division assignment(基础分配)
total_pages = 23
total_pages //= 5
print(total_pages) # 4

## Modulus assignment(模量分配)
bits = 35
bits %= 2
print(bits) # 1

## Exponentiation assignment(指数赋值)
power = 2
power **= 3
print(power) # 8

## 还有其他增强赋值运算符，例如位运算符。它们包括问号、、和。
## 其中包括 &=  ^=  >>=  <<= 


# 函数:
## 函数是可重用的代码片段，它接受输入（参数）并返回输出。要调用函数，需要引用函数名，后跟一对括号：

## Defining a function(函数定义)
def get_sum(num_1, num_2):
    return num_1 + num_2
result = get_sum(3, 4) # function call
print(result) # 7

## 如果一个函数没有显式返回值，则默认返回值为None
def greet():
    print('hello') 
result = greet() # hello
print(result) # None

### 还可以像这样为参数提供默认值：
def get_sum(num_1, num_2=2):
    return num_1 + num_2
result = get_sum(3) 
print(result) # 5

## 如果调用函数时没有传入正确数量的参数，将会得到一个错误
##TypeError  ：
#def calculate_sum(a, b):
    #print(a + b)
#calculate_sum()
# TypeError: calculate_sum() missing 2 required positional arguments: 'a' and 'b'


# 常用内置功能: 
## input()
### 提示用户输入
#name = input('What is your name?') # User types 'Kolade' and presses Enter  
print('Hello', name) # Hello Kolade

## int()
### ：用于将数字、布尔值或数字字符串转换为整数：
print(int(3.14)) # 3
print(int('42')) # 42
print(int(True)) # 1
print(int(False)) # 0 


# python中的作用域
## 局部作用域
### 这是指在函数或类内部声明的变量只能在该函数或类内部访问。
def my_func():
    num = 10
    print(num)

    ## 封闭作用域
### 这是指嵌套在另一个函数中的函数可以访问它所嵌套的函数的变量。
def outer_func():
    msg = 'Hello there!'
    def inner_func():
        print(msg)
    inner_func( )
print(outer_func()) # Hello there!

## 全局作用域
### 这指的是在任何函数或类之外声明的变量，可以从程序中的任何位置访问这些变量。
tax = 0.70 
def get_total(subtotal):
    total = subtotal + (subtotal * tax)
    return total
print(get_total(100))  # 170.0

## 内置作用域
### Python 中为预定义函数、模块、关键字和对象保留的名称。
print(str(45)) # '45'
print(type(3.14)) # <class 'float'>
print(isinstance(3, str)) # False


# 比较运算符:
# 等于( == ) ：检查两个值是否相等：
# 不等于 ( != )  : 检查两个值是否相等：
# 严格大于 ( > )  : 检查一个值是否大于另一个值：
# 严格小于 ( < )  : 检查一个值是否小于另一个值：
# 大于或等于( >= ) ：检查一个值是否大于或等于另一个值：
# 小于等于( <= ) ：检查一个值是否小于或等于另一个值：


# if、elif和else语句
## if,如果判断条件为 True 时执行对应代码块
age = 18
if age >= 18:
    print('You are an adult') # You are an adult

## elif 在 if 之后，如果 if 为 False, elif 为 True 时执行 elif 中的代码块
age = 16
if age >= 18:
    print('You are an adult')
elif age >= 13:
    print('You are a teenager')  # You are a teenager

    ## else 条件，如果上述代码块为 False 时执行 else 中的代码块
age = 12
if age >= 18:
    print('You are an adult')
elif age >= 13:
    print('You are a teenager')
else:
    print('You are a child')  # You are a child

## 还可以使用 if 嵌套语句:
is_citizen = True
age = 25
if is_citizen:
    if age >= 18:
        print('You are eligible to vote') # You are eligible to vote
else:
    print('You are not eligible to vote')
### 注： 在使用 if-elif-else 判断条件时代码块要注意缩进

# 真值和假值
### 在 Python 中，每个值都具有固有的布尔值，或者说，它内置了逻辑含义，表明该值在逻辑上下文中应被视为真True 还是假 False。
### 许多值被认为是 真值，
### 在逻辑上下文中 False  被评估为真。其他值则是假值，这意味着它们被评估为假
### 假值示例： 
# None
# False
# Integer 0
# Float 0.0
# Empty strings ''

### 其他值，例如非零数字和非空字符串，都是真值。


# bool()函数
## 如果想检查一个值是真值还是假值，可以使用内置bool()函数。它会将值显式转换为其布尔值，并分别返回True真值和False假值。
## 示例：
print(bool(False)) # False
print(bool(0))  # False
print(bool('')) # False
print(bool(True)) # True
print(bool(1)) # True
print(bool('Hello')) # True


# 布尔运算符和短路求值
## ：这些是特殊的运算符，允许您组合多个表达式，从而在代码中创建更复杂的决策逻辑。Python 中有三个布尔运算符：
'''
and
or
和
not
'''

## and 运算符
### 此运算符接受两个操作数，如果第一个操作数为假，则返回第一个操作数；否则，返回第二个操作数。表达式的两个操作数都必须为真，结果才为真值。
is_citizen = True
age = 25
print(is_citizen and age) # 25

### 还可以在条件运算符中使用 and 运算符
is_citizen = True
age = 25
if is_citizen and age >= 18:
    print('You are eligible to vote') # You are eligible to vote
else:
    print('You are not eligible to vote')

    ## or 运算符
### 如果第一个操作数为真，则此运算符返回第一个操作数；否则，返回第二个操作数。如果至少一个操作数为真，则“或”表达式的结果为真。例如：
age = 19
is_employed = False
print(age or is_employed) # 19

### 同样可以在判断条件中使用 or 运算符
age = 19
is_student = True
if age < 18 or is_student:
    print('You are eligible for a student discount') # You are eligible for a student discount
else:
    print('You are not eligible for a student discount')

## 短路运算
'''
and
和
or
运算符被称为短路运算符。短路运算意味着 Python 会从左到右检查值，并在确定最终结果后立即停止。
'''

## not 运算符
'''
：此运算符接受一个操作数，并反转其布尔值。它将真值转换为真
False
，假值转换为假
True
。与我们之前看到的运算符不同，它
not
始终返回真
True
或假
False
'''
print(not '') # True, because empty string is falsy
print(not 'Hello') # False, because non-empty string is truthy
print(not 0) # True, because 0 is falsy
print(not 1) # False, because 1 is truthy
print(not False) # True, because False is falsy
print(not True) # False, because True is truthy

## 条件语句中的 not
is_admin = False
if not is_admin:
    print('Access denied for non-administrators.') # Access denied for non-administrators.
else:
    print('Welcome, Administrator!')

