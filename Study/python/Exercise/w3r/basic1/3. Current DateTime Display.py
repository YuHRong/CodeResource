# Write a Python program to display the current date and time.

# 导入时间模块
import datetime

# 创建一个表示当前日期和时间的 datetime 对象
now = datetime.datetime.now();


#显示一条消息，指示正在打印的内容
print('Current date and time : ')

# 以特定时间打印日期和时间
print(now.strftime('%Y/%m/%d %H:%M:%S'))