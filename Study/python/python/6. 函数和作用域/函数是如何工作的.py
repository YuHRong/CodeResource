#函数

## input()函数，提示用户输入

name = input('What\'s your name?')
print('Hello', name)

## int()可以将数字、布尔值和数值字符串转换为整数：
print(int(3.14159))
print(int('43'))
print(int(True)) ###1
print(int(False)) ###0

'''
 您还可以编写自己的自定义函数。为此，您可以使用
 def
关键字，后跟要为函数命名的名称、一对括号和冒号。
Then on a new line, you write the code your function should run.
'''

def hello():
    print('Hello World!')
    hello()

def calculate_sum(a, b):
    print(a + b)
calculate_sum(3, 1)