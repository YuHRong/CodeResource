import math
import math as m
from math import radians, sin, cos
from math import *
import datetime

'''
Python 拥有丰富的标准函数库，包含许多不同的内置模块。它们都是针对程序员日常会遇到的许多问题和任务的标准化、经过充分验证的方案，例如：
• 与操作系统交互。
• 处理文件。
• 网络。
• 处理日期和时间。
• 执行数学操作。
• 使用正则表达式。
• 测试和调试你的代码。
• 以及更多！
一些流行的内置模块示例有  math 、 random 、 re  （“regular expressions”的缩写）和 
datetime  。
math   模块有用于执行更复杂数学操作的帮助函数。
random   模块对于生成随机数很有帮助。
re   模块用于处理正则表达式。
而且  datetime  模块对于在 Python 中处理日期和时间非常有帮助。

在 python 文件顶部使用
import
语句导入一个模块。你可以导入整个模块，或者只导入模块中的特定函数或类。
格式为：
import module_name
例如导入 math 模块：
inport math
使用 . (点) 运算符访问模块中的函数或类。
格式为：
module_name.function_name
例如，要使用 math 模块中的 sqrt() 函数计算一个数字的平方根，你可以这样写：
math.sqrt(36) # 6.0
'''

'''
可以使用 
as  关键字为模块指定一个别名。这对于模块名称较长或你想使用更简短的名称来引用模块时很有用。
格式为：
inport module_name as module_alias
例如，要为  math  模块指定一个别名  m  ，你可以这样写：
import math as m
就可以使用 m  来访问模块中的函数或类：
m.sqrt(36) # 6.0
'''

'''
import语句使用from关键字从模块中导入特定函数或类。格式为：
from module_name import function_name
例如，要从  math  模块中导入  sqrt()  函数，你
可以这样写：
from math import sqrt
可以使用 as 关键字为导入的函数指定一个别名：
格式为：
from module_name import function_name as function_alias
假设你只想从  math   模块导入 radians、sine 和 cosine 函数。你可以这样写：
from math import radians, sin, cos
现在你可以直接使用这些函数，而不需要模块名称作为前缀：
'''

print(math.sqrt(36))

print(m.sqrt(36))

print('使用 from 语句导入特定函数')

print('使用 radians 函数将角度转换为弧度，调用正弦和余弦函数传入弧度角：')

angle_degrees = 40

angle_radians = radians(angle_degrees)

sine_value = sin(angle_radians)

cos_value = cos(angle_radians)

print('sine:', sine_value)    # 0.6427876096865394
print('cosine:', cos_value)  # 0.766044443118978


# 注： 在导入模块时，要注意变量或者函数命名

'''
使用 * （星号）导入模块中的所有函数和类。格式为：
from module_name import *
例如：
from math import *
'''

print('sqrt: ', sqrt(36)) # 6.0

print('pow: ', pow(5, 2)) # 25.0

print('exp: ',exp(1)) # 2.718281828459045

print('math 中 py 的常量示例')

print(math.pi) # 3.141592653589793

print('datetime 模块示例')

birthday = datetime.date(1959, 7, 15)

print('日： ', birthday.day)    # 15
print('月： ', birthday.month)  # 7
print('年： ', birthday.year)   # 1959

print('生日： ', birthday) # 1959-07-15

'''
很好。既然你对模块有了更多了解，你也应该知道 Python 脚本中这个非常重要的惯用法，因为它们关系非常密切： 
if __name__ == '__main__':  

# Code

 __name__ 是 Python 中一个特殊的内置变量。
当一个 Python 文件被直接执行时，Python 会将这个变量的值设置为字串  "__main__"。
但是如果 Python 文件作为模块被导入到另一个 Python 脚本中， __name__
 变量的值将被设置为该模块的名称（通常是没有  .py 扩展名的文件名）。
这就是为什么你经常会在 Python 脚本中看到这个条件式。它包含你只想在 Python 脚本作为主程序运行时才运行的代码： 
if __name__ == '__main__':  

# Code
但是如果脚本作为模块被导入，那个块内的代码不会运行
'''

