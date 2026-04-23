
print('使用 def 关键字定义函数')

def square(num):
 
    return num ** 2
print(square(4)) # 16

# 但是当涉及使用像  map()  和  filter()   这样的高阶函数时，你可以使用匿名内联函数。这就是 lambda 函数的用武之地。

print('将 square() 函数重构为 lambda 函数')
lambda num: num ** 2

numbers = [1, 2, 3, 4, 5]

even_numbers = list(filter(lambda x: x % 2 == 0, numbers))
print(even_numbers)  # [2, 4]

'''
在这个例子中，我们有一个数字列表，想要创建一个新的偶数列表。所以我们将一个 lambda 函数作为参数传递给
filter()   函数，以获得一个包含数字 2   和  4   的新列表。
'''

