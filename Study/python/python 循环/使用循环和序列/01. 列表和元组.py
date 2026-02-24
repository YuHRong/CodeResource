# 工作原理

'''
lists
tuples
ranges
他们是python 中最基本的基本序列类型。
'''
##列表数据类型是由字串、数字甚至其他列表组成的数组元素序列。列表是可变的，使用零基索引，这意味着列表的第一个元素位于零基索引。

## 基础语法： 

cities = ['Los Angeles', 'London', 'Tokyo']
## 访问 cities 中的第一个列表可以使用: 
cities[0]
print(cities[1])
## 访问最后的列表元素可以使用 "减号"来进行访问，如： 
cities[-1]
print(cities[-1])

## 列表是可变的，这意味着我们可以修改列表中的元素。我们可以使用索引来修改列表中的元素，如：
cities[0] = 'New York'
print(cities)
## 列表还支持切片操作，可以使用切片来访问列表中的一部分元素，如：
print(cities[0:2])
## 切片操作还支持步长参数，可以使用步长来指定切片的步长，如：
print(cities[0:3:2])

## 列表还支持一些常用的内置函数，如 len()、max()、min()、sum() 等，这些函数可以用来对列表中的元素进行操作，如：
print(len(cities))
print(max(cities))
print(min(cities))

'''
## 列表还支持一些常用的内置函数，如 sorted()、reversed() 等，这些函数可以用来对列表中的元素进行排序和反转，如：
print(sorted(cities))
print(list(reversed(cities)))

## 列表还支持一些常用的内置函数，如 enumerate()、zip() 等，这些函数可以用来对列表中的元素进行枚举和组合，如：
for index, city in enumerate(cities):
    print(index, city)
other_cities = ['Sydney', 'Melbourne']
for city1, city2 in zip(cities, other_cities):
    print(city1, city2)

## 列表还支持一些常用的内置函数，如 any()、all() 等，这些函数可以用来对列表中的元素进行判断，如：
print(any(cities))
print(all(cities))

## 列表还支持一些常用的内置函数，如 list()、tuple() 等，这些函数可以用来将列表转换为其他类型，如：
print(list(cities))
print(tuple(cities))

## 列表还支持一些常用的内置函数，如 map()、filter() 等，这些函数可以用来对列表中的元素进行映射和过滤，如：
print(list(map(str.upper, cities)))
print(list(filter(lambda city: 'o' in city, cities)))

## 列表还支持一些常用的内置函数，如 sum()、max()、min() 等，这些函数可以用来对列表中的元素进行求和、求最大值、求最小值等操作，如：
numbers = [1, 2, 3, 4, 5]
print(sum(numbers))
print(max(numbers))
print(min(numbers))

## 列表还支持一些常用的内置函数，如 sorted()、reversed() 等，这些函数可以用来对列表中的元素进行排序和反转，如：
print(sorted(numbers))
print(list(reversed(numbers)))

## 列表还支持一些常用的内置函数，如 enumerate()、zip() 等，这些函数可以用来对列表中的元素进行枚举和组合，如：
for index, number in enumerate(numbers):
    print(index, number)
other_numbers = [6, 7, 8]
for number1, number2 in zip(numbers, other_numbers):
    print(number1, number2)
'''

## 可以使用 del 语句来删除列表中的元素，如：
del cities[0]
print(cities)

## 可以使用 in 关键字来检查列表中是否存在某个元素，如：
print('Beijing' in cities)
## 可以使用 not in 关键字来检查列表中是否不存在某个元素，如：
print('Paris' not in cities)

## 有时常见的情况是在其他列表中列出列表，如下所示：
developer = ['Alice', 25, ['Python', 'Rust', 'C++']]
print(developer[0])  # 输出: Alice
print(developer[1])  # 输出: 25
print(developer[2])  # 输出: ['Python', 'Rust', 'C++']
print(developer[2][0])  # 输出: Python

## 另一种常用的技术是对列表进行解包值。例如，如果我们有一个包含三个元素的列表，我们可以将这些元素解包到三个变量中，如下所示：
name, age, languages = developer
print(name)  # 输出: Alice
print(age)   # 输出: 25
print(languages)  # 输出: ['Python', 'Rust', 'C++']

## 还可以使用 * 运算符来解包列表中的剩余元素，如下所示：
developer = ['Alice', 34, 'Rust Developer']
name, age, *rest = developer
print(name)  # 输出: Alice
print(age)   # 输出: 34
print(rest)  # 输出: ['Rust Developer']

# 列表常用的方法
## 列表还支持一些常用的方法，如 append()、extend()、insert()、remove()、pop() 等，这些方法可以用来修改列表中的元素，如：

## append() 方法可以用来在列表的末尾添加一个元素，如：
number = [1, 2, 3, 4, 5]
number.append(6)
print(number)

##如果你想将一个列表添加到另一个列表的补充，你也可以像这样使用append()  方法：
even_number = [6, 8, 10]
number.append(even_number)
print(number)    # [1, 2, 3, 4, 5, [6, 8, 10]]
## extend() 方法可以用来在列表的末尾添加一个可迭代对象中的所有元素，如：
number = [1, 2, 3, 4, 5]
even_number = [6, 8, 10]
number.extend(even_number)
print(number)    # [1, 2, 3, 4, 5, 6, 8, 10]

## insert() 方法可以用来在列表的指定位置插入一个元素，如：
number = [1, 2, 3, 4, 5]
number.insert(0, 0)
print(number)    # [0, 1, 2, 3, 4, 5]
number.insert(3, 2.5)
print(number)    # [0, 1, 2, 2.5, 3, 4, 5]

## remove() 方法可以用来删除列表中的第一个匹配项，如：
number = [0, 1, 2, 2.5, 3, 4, 5]
number.remove(2.5)
print(number)    # [0, 1, 2, 3, 4, 5]

## pop() 方法可以用来删除列表中的指定位置的元素，并返回该元素的值，如：
number = [0, 1, 2, 3, 4, 5, 0, 0]
popped_number = number.pop(0)
print(popped_number)    # 0
print(number)    # [1, 2, 3, 4, 5, 0, 0]

## 如果你需要清空列表，那么你可以像这样使用clear()  方法：
number = [1, 2, 3, 4, 5]
number.clear()
print(number)    # []

## 接下来我们将查看的 sort()  方法。此方法用于就地排序元素。以下是就地排序一个随机数字列表的示例：
number = [3, 1, 4, 1, 5, 9]
number.sort()
print(number)    # [1, 1, 3, 4, 5, 9]

## sort() 方法还支持一个可选的 reverse 参数，可以用来指定排序的顺序，如：
number = [3, 1, 4, 1, 5, 9]
number.sort(reverse=True)
print(number)    # [9, 5, 4, 3, 1, 1]

## sorted()函数适用于任何可迭代对象，并返回一个新的排序列表，而不是修改原始列表。例如：
number = [3, 1, 4, 1, 5, 9]
sorted_number = sorted(number)
print(sorted_number)    # [1, 1, 3, 4, 5, 9]
print(number)    # [3, 1, 4, 1, 5, 9]

## 接下来我们将查看的 reverse()  方法。此方法将原地获取元素列表，如下所示：
number = [1, 2, 3, 4, 5]
number.reverse()
print(number)    # [5, 4, 3, 2, 1]

## 我们将忽略的最后一个方法是 index  method。它用于查找元素在列表中第一次出现的索引。下面是使用 index() 方法查找元素索引的示例：
number = [1, 2, 3, 4, 5]
index_of_3 = number.index(3)
print(index_of_3)    # 2
## 如果列表中有多个相同的元素，index() 方法将返回第一个匹配项的索引，如：
number = [1, 2, 3, 4, 5, 3]
index_of_3 = number.index(3)
print(index_of_3)    # 2


# 元组及其工作原理是什么

## 元组是Python的一种数据类型，用于创建数组的值序列。元组可以包含像这样的混合的数据类型：
developer = ('Alice', 34, 'Rust Developer')
## 元组同样是列表，但列表是可修改的数据类型，而元组是不可修改的。这意味着元组中的元素在创建后不能被更改。
## 要访问元组中的元素，你可以使用方括号弧表示法和索引号：
print(developer[0])  # 输出: Alice
print(developer[1])  # 输出: 34
print(developer[2])  # 输出: Rust Developer
## 你也可以使用负索引来访问元组中的元素，如：
print(developer[-1])  # 输出: Rust Developer
print(developer[-2])  # 输出: 34
print(developer[-3])  # 输出: Alice

## 另一种创建元组的方法是使用 tuple() 构造函数，如下所示：
developer = 'Jessica'
tuple(developer) # ('J', 'e', 's', 's', 'i', 'c', 'a')
print(tuple(developer))

## 要查看一个是否在元组中，你可以像这样使用 in 关键字：
print('Alice' in developer)  # 输出: True
print('Bob' in developer)    # 输出: False
## 你也可以使用 not in 关键字来检查一个元素是否不在元组中，如：
print('Alice' not in developer)  # 输出: False
print('Bob' not in developer)    # 输出: True

## 你也可以像处理列表一样从元组中解包项：   
name, age, profession = developer
print(name)  # 输出: Jessica
print(age)   # 输出: 34
print(profession)  # 输出: Rust Developer

## 你也可以使用 * 运算符来解包元组中的剩余元素，如下所示：
developer = ('Jessica', 34, 'Rust Developer', 'Python Developer')
name, age, *rest = developer
print(name)  # 输出: Jessica
print(age)   # 输出: 34
print(rest)  # 输出: ['Rust Developer', 'Python Developer']

## 就像对列表一样，您对元组使用切片符操作可以提取其中的一部分。下面一个项目是一个元组切片的示例：
desserts = ('cake', 'pie', 'cookies', 'ice cream')
desserts[1:3] # ('pie', 'cookies')
print(desserts[1:3])  # 输出: ('pie', 'cookies')
### 请记住，第一个数字表达式提取的起始索引，而第二个数字表达式结束索引。但请注意，结束索引处的项不包含在提取的元组中。
### 如果你需要从一个元组中删除一个，这是不可能的，因为元组是不可变的。所以这个例子会产生一个错误：
### desserts.remove('pie')  # 这会引发 AttributeError，因为元组不支持 remove 方法
'''
那么什么时候你会使用tuple  not is list  ？
如果你需要一个可以添加、删除和更新元素的动态集合，那么你应该使用列表。如果你知道你正在处理一个固定且不可变的数据集合，那么你应该使用元组。例如，如果你有一个表示一个人的信息的集合，如姓名、年龄和职业，并且这些信息不会改变，那么你可以使用元组来存储这些信息，如：
'''
developer = ('Alice', 34, 'Rust Developer')
print(developer[0])  # 输出: Alice
print(developer[1])  # 输出: 34
print(developer[2])  # 输出: Rust Developer

## 但是，如果你需要一个可以修改的集合来存储一个人的信息，那么你应该使用列表，如：
developer = ['Alice', 34, 'Rust Developer']
print(developer[0])  # 输出: Alice
print(developer[1])  # 输出: 34
print(developer[2])  # 输出: Rust Developer

# 元组的方法有哪些
## 元组支持一些常用的方法，如 count() 和 index() 等，这些方法可以用来对元组中的元素进行计数和查找，如：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
print(developer.count('Alice'))  # 输出: 2
print(developer.index('Rust Developer'))  # 输出: 2

## 下一个我们要查看的方法是index()方法。它用于查找元素在元组中第一次出现的索引。下面是使用index()方法查找元素索引的示例：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
index_of_alice = developer.index('Alice')
print(index_of_alice)  # 输出: 0
## 如果元组中有多个相同的元素，index()方法将返回第一个匹配项的索引，如：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
index_of_alice = developer.index('Alice')
print(index_of_alice)  # 输出: 0

## 您还可以使用 index()  方法指定任选的起始和结束索引参数。以下是指定任选起始索引的示例：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
index_of_alice = developer.index('Alice', 1)
print(index_of_alice)  # 输出: 3
## 以下是指定任选结束索引的示例：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
index_of_alice = developer.index('Alice', 0, 3)
print(index_of_alice)  # 输出: 0
## 以下是指定任选起始和结束索引的示例：
developer = ('Alice', 34, 'Rust Developer', 'Alice')
index_of_alice = developer.index('Alice', 1, 3)
print(index_of_alice)  # 输出: 3

## 另一个常用的用于元组的函数是sorted()函数。它用于对元组中的元素进行排序，并返回一个新的排序列表，如：
numbers = (3, 1, 4, 1, 5, 9)
sorted_numbers = sorted(numbers)
print(sorted_numbers)  # 输出: [1, 1, 3, 4, 5, 9]
## 请注意，sorted()函数返回一个新的列表，而不是修改原始元组，因为元组是不可变的。
## sorted()  函数总是创建一个排序值的新列表。这与 sort()  方法不同，晚上会就排序列表的元素且不返回新列表。

## 如果你需要为可迭代对象自定义排序行为，可以使用可选的reverse  和key  参数。下面是使用 key  参数按长度对元组中的项进行排序的示例：
programming_languages = ('Rust', 'Java', 'Python', 'C++', 'Rust', 'Python')
sorted(programming_languages, key=len)
# Result: ['Rust', 'Java', 'C++', 'Python', 'Rust', 'Python']
print(sorted(programming_languages, key=len))

## 如果您想创建一个按顺序排列的新值列表，那么您可以像这样使用reverse  参数：    
programming_languages = ('Rust', 'Java', 'Python', 'C++', 'Rust', 'Python')
sorted(programming_languages, reverse=True)
# Result: ['Rust', 'Rust', 'Python', 'Python', 'Java', 'C++']
print(sorted(programming_languages, reverse=True))
### 元组是Python中常见的数据类型。了解如何使用它们，以及一些高效有用的方法和函数，将帮助你编写更多的代码。


