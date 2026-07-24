# Write a Python program that accepts a sequence of comma-separated numbers from the user and generates a list and a tuple of those numbers.

# 提示用户输入逗号分隔的数字序列并将其存储在“values”变量中
values = input("Input some comma-separated numbers: ")

# 使用逗号作为分隔符将“values”字符串拆分为列表，并将其存储在“list”变量中
lists = values.split(',')

#将“list”转换为元组并将其存储在“tuple”变量中
tuple = tuple(lists)

print('list ', lists)
print('tuple', tuple)

input('回车退出')