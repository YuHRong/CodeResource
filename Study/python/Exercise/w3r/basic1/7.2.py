# 提示输入文件名并存储在 fN 中
fN = input('input file name')

# 使用 '.' 分割字符串并存储在 file_name 中
file_name = fN.split('.')

# 打印 file_name[0] 第一个元素
print('file name is', repr(file_name[0]))