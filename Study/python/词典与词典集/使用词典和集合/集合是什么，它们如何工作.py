'''
集合是 Python 的内置数据结构之一。集合的核心特性之一是它们不保存重复的值。如果你尝试将重复的值添加到集合中，只有其中一个会被保存。
集合是可变的且无序的，这意味着它们的元素不会以任何特定顺序保存，因此你不能使用索引或密钥来访问它们。它们只能包含不可变的数据类型的值，如数字、字串和元组。并且它们支持数学集合操作，包括并集、交集、差集和对称差集。
要定义一个集合，你只需将其元素写在括弧状的花括弧内，并用逗号分隔它们。这是一个数字集合的示例：
'''

my_set = {1, 2, 3, 4, 5} 
print(my_set)

'''
如果需要定义一个空集合，必须使用
set()
函数。如果你只是写空的括弧状的花括弧，比如
{}
，Python 会自动创建一个字典。
'''

set() # set()
{}   # Dictionary

'''
可以使用
.add()
方法为集合添加一个元素，并将新元素作为参数传入：
'''

my_set.add(6)

'''
在上面示例中， 新建 集合将是：
{1, 2, 3, 4, 5, 6}
'''

print(my_set)

# 在 python 中集合只能存在一个元素

my_set.add(5)
print(my_set) # {1, 2, 3, 4, 5, 6}


'''
可以使用
.remove()
方法或
.discard()
移除指定元素。
两者之间的区别在于，如果你尝试移除一个不存在的元素， .remove()  会引发一个错误，而 .discard()  不会：
'''

print('remove方法：')
my_set.remove(4)
print(my_set)

print('discard方法：')
my_set.discard(4)
print(my_set)

'''
使用
.clear()
方法从集合中移除所有元素：
'''

print('clear方法：')
my_set.clear()
print(my_set) # set()

# Python 集合中执行常见数学集合操作的方法。

'''
.issubset()
和
.issuperset()
方法分别查看一个集合是否是另一个集合的子集或超集。
下例中，查看 your_set 是否是 my_set 的子集，以及 my_set 是否是 your_set 的超集：
因为 your_set 的所有元素并不都在my_set 中，所以结果是False。
因为 my_set 不包含 your_set 的所有元素，所以结果也是 False。
'''

print('issubset方法，查找子集')

my_set = {1, 2, 3, 4, 5}
your_set = {2, 3, 4, 6}

print(your_set.issubset(my_set)) # False

print('issuperset方法，查找超集')
print(my_set.issuperset(your_set)) # False

'''
.isdisjoint()
方法查看两个集合是否不相交，这意味着它们没有任何共同的元素。在这个示例中，结果是
False  ，因为  my_set   和  your_set   确实有共同的元素——2、3 和 4：
'''

print('isdisjoint方法，查找不相交的集合') 
print(my_set.isdisjoint(your_set)) # False

'''
并集操作符
|
返回一个包含两个集合中所有元素的新建集合：
'''

print('并集操作符 | （竖杠）')
print(my_set | your_set) # {1, 2, 3, 4, 5, 6}

'''
交集操作符
& （和号
返回一个只包含集合共有元素的新建集合：
'''

print('交集操作符 & （和号）')
print(my_set & your_set) # {2, 3, 4}

'''
差集操作符
- （减号）
返回一个包含在第一个集合中但不在第二个集合中的元素的新建集合：

'''

print('差集操作符 - （减号）')
print(my_set - your_set) # {1, 5}

'''
对称差集操作符
^ （脱字符）
返回一个包含在第一个集合或第二个集合中但不在两个集合中的元素
'''

print('对称差集操作符 ^ （脱字符）')
print(my_set ^ your_set) # {1, 5, 6}

'''
每个这些操作符如果在旁边添加等号，也都有对应的复合赋值操作符。这些操作符会自动将结果集赋值给表达式中的第一个集合：
|= &= -= ^=
例如， -=  操作符查找集合之间的差异并用该结果更新第一个集合：
'''

print('使用 -= 操作符更新集合')

my_set -= your_set
print(my_set) # {1, 5}

print('使用 in 操作符检查元素（5）是否在集合中')

print(5 in my_set) # True
print(5 in your_set ) # False

''''''