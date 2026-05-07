print('使用 + (加号) 连接字符串')

my_str_1 = 'Hello'
my_str_2 = 'World'

str_plus_str = my_str_1 + ' ' + my_str_2

print(str_plus_str)

print('使用 str() 方法将非字符串类型转换为字符串')

name = 'John Doe'

age = 26
name_and_age = name + str(age)
print(name_and_age)

print('使用 += （加等于)运算符连接字符串')

name_age = name
name_age += str(age)
print(name_age)

print('使用 f 字符串格式化连接字符串')

print(f'my name is {name} ane i am {age} years old')

