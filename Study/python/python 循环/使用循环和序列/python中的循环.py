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

