
even_numbers = []
for num in range(21):

 if num % 2 == 0:

    even_numbers.append(num)
    print(even_numbers)

print('列表推导式')

even_numbers = [num for num in range(21) if num % 2 == 0]
print(even_numbers)

print('新示例')

numbers = [1, 2, 3, 4, 5]

result = [(num, 'Even') if num % 2 == 0 else (num, 'Odd') for num in numbers]
print(result)

print('filter() 函数')

words = ['tree', 'sky', 'mountain', 'river', 'cloud', 'sun']
def is_long_word(word):

      return len(word) > 4

long_words = list(filter(is_long_word, words))
print(long_words) # ['mountain', 'river', 'cloud']

'''
filter()函数用于从可迭代对象中选择满足特定条件的元素。
filter()函数接受一个函数和一个可迭代对象作为它的参数。在上面示例中，我们将
is_long_word函数传递给
filter()函数，以查看当前单词数是否大于4。。所有字符数大于4的单词都被添加到一个新列表中，并赋值给
long_words变量。

map()
函数，接受一个可迭代对象并对其每个元素应用一个函数。下面是使用
map() 函数的示例。
'''

print('map() 函数')

celsius = [0, 10, 20, 30, 40]
def to_fahrenheit(temp):

    return (temp * 9/5) + 32

fahrenheit = list(map(to_fahrenheit, celsius))
print(fahrenheit)  # [32.0 50.0, 68.0, 86.0, 104.0]

'''
map()   接受一个函数和一个可迭代对象作为它的参数。
to_fahrenheit   函数接受一个温度并将其从摄氏度转换为华氏度。

sum()   函数。这个函数用于从可迭代对象（如列表或元组）中获取总和。以下是使用 
sum()   函数的示例
'''

print('sum() 函数')

numbers = [5, 10, 15, 20]

total = sum(numbers)
print(total)  # 50

'''
也可以传入一个可选的  start   参数，用于设置求和的初始值。下面是一个使用 
start   参数作为位置参数的更新示例
'''

print('传入 start 参数示例')

numbers = [5, 10, 15, 20]

total = sum(numbers, 10)  # positional argument
print(total)  # 60

# 你也可以选择将  start  参数作为关键字参数这样使用：

print('start 示例2')

numbers = [5, 10, 15, 20]

total = sum(numbers, start=10) # keyword argument
print(total) # 60

