# Write a Python program that accepts a filename from the user and prints the extension of the file.

fileName = input('Input file name')

# 使用 . 分割字符串
file_list = fileName.split(".")

# 打印扩展名
print(repr(file_list[-1]))