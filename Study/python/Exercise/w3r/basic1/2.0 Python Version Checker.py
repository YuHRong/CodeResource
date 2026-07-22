# Write a Python program to find out what version of Python you are using.

# 导入 sys 模块访问系统特定参数
import sys

#将 Python版本打印到控制台
print('python version: ')
# 使用 sys.version 属性获取 python 版本并打印
print(sys.version)

# 打印有关 python 版本信息
print('Version info.')
# 使用sys.version_info属性获取详细的版本信息并打印出来
print(sys.version_info)