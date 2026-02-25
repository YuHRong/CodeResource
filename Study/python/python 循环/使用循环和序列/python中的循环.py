# 循环是如何工作的

## for 循环
programming_languages = ['Rust', 'Java', 'Python', 'C++']
print('循环迭代列表并打印')
for language in programming_languages:
    print(language)

    ## 你也可以使用 for 循环来迭代一个字符串，如：
print('循环访问字符串')
for char in 'Code':
    print(char)


## 就像在 JavaScript 中一样，你也可以在 Python 中的湖泊for  循环。下面是使用湖泊for  循环迭代一个列表的示例：
print('湖泊for 循环')
categories = ['Fruit', 'Vegetable']
foods = ['Apple', 'Carrot', 'Banana']
for category in categories:
    for food in foods:
        print(category, food)

## while 循环
## while 循环在满足特定条件时重复执行一段代码。直到条件为 False 时停止。下面是使用 while 循环的示例：
print('while 循环（已注释')
'''
secret_number = 3
guess = 0
while guess != secret_number:

    guess = int(input('Guess the number (1-5: )'))

    if guess != secret_number:

        print('Wrong! Try again.')
print('You got it!')
'''

## 也可以使用 break 和 continue 语句来控制循环的执行。break 语句用于立即退出循环，而 continue 语句用于跳过当前迭代并继续下一次迭代。下面是使用 break 的示例：
print('使用 break')
developer_names = ['Jess', 'Naomi', 'Tom']
for developer in developer_names:

    if developer == 'Naomi':
        print('Found Naomi! Exiting loop.')
        break
    print(developer)
## 下面是使用 continue 的示例：
print('使用 continue')
developer_names = ['Jess', 'Naomi', 'Tom']
for developer in developer_names:

    if developer == 'Naomi':
        print('Found Naomi! Skipping to next iteration.')
        continue
    print(developer)

## for  和while  循环都可以和else  子句结合使用，只有当循环没有被break  语句终止时才会执行该子句。下面是使用多个 for  循环的示例：
words = ['sky', 'apple', 'rhythm', 'fly', 'orange']
for word in words:

    for letter in word:

        if letter.lower() in 'aeiou':

            print(f"'{word}' contains the vowel '{letter}'")
            break

    else:
        print(f"'{word}' has no vowels")

## 循环在Python中非常常见，因此非常熟悉它们。在接下来的几节课中，你将学习如何在循环中使用enumerate()  和 range()  函数。

# 什么是 range，以及需要怎样使用

## range()  函数是一个内置函数，用于生成一个整数序列。它可以接受一个、两个或三个参数，分别表示起始值、结束值和步长。下面是一些使用 range()  函数的示例：
print('range()函数示例')
### range() 基本语法
### range(start, stop, step)
### stop 参数是一个整数，表现为所生成数字序列的终点。以下是使用 range() 函数的示例: 
print('指定结束点的 range() stop')
for num in range(3):
    print(num)

'''
以上代码生成介于  0  和  2  之间的数字序列。整数  3  不包含在内，因为 range()  函数的 stop 参数是不包含端点的。
如果未指定  start  参数，则默认值为  0 。否则，你可以使用可选的 
start   参数从非  0   的整数开始整数序列。下面是生成介于  1   和  4   之间整数序列的示例：
'''

print('指定开始点的 range() start')
for num in range(1, 5):
    print(num)

'''
默认情况下，整数序列将以  1   递增。但如果你想更改该默认值，则可以使用可选的 
step   参数。以下是生成介于  2   和  10   之间偶数序列的示例：
'''
print('指定步长的 range(), stip')
for num in range(2, 11, 2):
    print(num)

### 如果你想生成一个递减顺序的整数序列，那么你可以为 step   参数使用负整数，像这样：
print('生成递减顺序的 range()')
for num in range(40, 0, -10):
    print(num)

'''
你还可以使用  range()   函数配合  list   构造来创建一个整数列表。 
list 构造用于将可迭代对象转换为列表。下面是生成一个介于  2  和  10   之间偶数整数列表的示例：
'''
print('使用 list 构造创建一个整数列表')
numbers = list(range(2, 11, 2))
print(numbers)

### range()   函数是在 Python 中生成整数序列的一个非常方便的方法。一旦你掌握了它，你可能会发现自己在 Python 程序中经常使用它。


# 什么是 Enumerate 和 Zip 函数，它们如何工作？

'''
enumerate()   函数跟踪可迭代对象的索引并返回一个枚举对象。它接受一个可迭代对象作为参数，并返回一个包含索引和值的元组的迭代器。
如果我们将  languages   列表传递给  enumerate()   函数，并使用  list() 
函数将其返回值转换为列表，它看起来像这样：
'''
print('使用 enumerate() 函数')
languages = ['Spanish', 'English', 'Russian', 'Chinese']
list(enumerate(languages))
print(list(enumerate(languages)))
''' 
输出：
[(0, 'Spanish'), (1, 'English'), (2, 'Russian'), (3, 'Chinese')]
每个元组的第一个元素是索引，第二个元素是列表中的值。你可以使用  for   循环来迭代这个枚举对象，并同时访问索引和值。下面是一个示例：
'''

