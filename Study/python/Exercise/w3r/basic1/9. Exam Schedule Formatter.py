# Write a Python program to display the examination schedule. (extract the date from exam_st_date).

# import datetime

exam_st_date = (11, 12, 2014)

# 使用字符串格式打印考试开始日期
# “%i”占位符由“exam_st_date”元组中的值填充
print('The examination will start from : %i / %i / %i' % exam_st_date)