my_str = "Hello World"

print(my_str[0])
print(my_str[6])
print(my_str[1])
print(my_str[4])

# 字符串切片让你能够提取字符串的一部分或仅处理其特定部分。
# 语法为： string[start:stop]
# 其中，start是起始索引（包含），stop是结束索引（不包含）。(起始跟结束军可以省略)

print(my_str[0:5])
print(my_str[:5])
print(my_str[5:])

# 除了  start  和  stop  索引外，还有一个可选的  step   参数，用于指定切片中每个索引之间的增量。'''
# string[start:stop:step]

my_str2 = 'Hello, World!'
print(my_str2[0:11:2])
print(my_str2[::-1])


# 字符串方法
# upper()   : 返回一个所有字符都转换为大写的新字符串。
my_str3 = "hello world"
uppercase_my_str3 = my_str3.upper()
print(uppercase_my_str3)
# lower()   : 返回一个所有字符都转换为小写的新字符串。
lowercase_my_str3 = my_str3.lower()
print(lowercase_my_str3)

# strip()   : 返回一个新字符串，移除指定的首尾字符。
# # 默认情况下，strip() 会移除空白字符（包括空格、制表符和换行符）。
# # 如果没有传入参数，则移除首尾空白字符。
my_str4 = "   Hello, World!   "
stripped_my_str4 = my_str4.strip()
print(stripped_my_str4)

# replace(old, new)   : 返回一个新字符串，将所有  old   的出现替换为 new
my_str5 = "Hello, World!"
replaced_my_str5 = my_str5.replace("World", "Python")
print(replaced_my_str5)

# split(separator)   : 将字符串按指定的分隔符分割成字符串列表。
##如果没有指定分隔符，它将按空白字符分割。
my_str6 = "Hello, World! Welcome to Python."
split_my_str6 = my_str6.split()
print(split_my_str6)

# join(iterable)   : 使用分隔符将可迭代对象的元素连接成一个字符串
my_list = ["Hello", "World", "from", "Python"]
joined_my_list = " ".join(my_list)
print(joined_my_list)

# startswith(prefix)   : 返回一个布尔值，指示字符串是否以指定的前缀开头。
my_str7 = "Hello, World!"
starts_with_hello = my_str7.startswith("H")
print(starts_with_hello)

# endswith(suffix)   : 返回一个布尔值，指示字符串是否以指定的后缀结尾。
ends_with_exclamation = my_str7.endswith("!")
print(ends_with_exclamation)

# find(substring)   : 返回  substring   第一次出现的位置索引，如果没有找到则返回 index -1
index_of_world = my_str7.find("World")
print(index_of_world)

# count(substring)   : 返回子字符串在字符串中出现的次数。
count_of_l = my_str7.count("l")
print(count_of_l)

# capitalize()   : 返回一个新字符串，首字母大写，其余字母小写。
my_str8 = "hello, world!"
capitalized_my_str8 = my_str8.capitalize()
print(capitalized_my_str8)

# isupper()   : 如果字符串中所有字母都是大写则返回  True   ，否则返回 False
is_all_upper = my_str7.isupper()
print(is_all_upper)

# islower()   : 如果字符串中所有字母都是小写则返回  True   ，否则返回 False
is_all_lower = my_str8.islower()
print(is_all_lower)

# title()   : 返回一个新字符串，其中每个单词的首字母都大写。
my_str9 = "hello world from python"
titled_my_str9 = my_str9.title()
print(titled_my_str9)