'''
有些时间程序正在运行时，你才可能知道需要哪些属性。想象一下，你正在编写一个脚本，该脚本从用户或配置文件接收属性名称。这些属性不是你可以提前硬编码的。
这就是动态处理属性的用武之地。通过这种方式，你可以使用属性名作为变量来访问、修改、查看甚至删除属性，而不是在你的代码中使用固定的名称。这赋予你的程序在运行中响应不同数据或用户输入的灵活性。
Python 为你提供了四个方便的内置函数，用于动态操作对象属性。它们是
getattr()
setattr()
hasattr()
delattr()
'''

'''
getattr()
使你能够在运行期不知道属性名称时从对象中读取属性。如果该属性不存在，它会引起一个
AttributeError
要使用它，你需要传入对象、属性名称和一个可选的默认值：
getattr(object, attribute_name, default_value) 

'''

print('getattr()示例')

class Person:  
    
    def __init__(self, name, age):  
        self.name =  name 
        self.age =  age 

person = Person('John Doe', 30)  
 
print(getattr(person, 'name')) # John Doe 
print(getattr(person, 'age')) # 30 
print(getattr(person, 'city', 'Milano')) # Milano

# 在上面的例子中， Milano  是一个默认值，因为  city  不存在于  Person 中。

#  另外，如果想要知道一个对象所存在的属性，可以使用 dir()方法，返回对象上所有属性列表，用法

class Person:
 
    def __init__(self, name, age):
     
        self.name = name
        self.age = age
        
person = Person('John Doe', 30)

# 使用 dir() 函数便利访问 person 所有属性
for attr in dir(person):
 

    # Ignore dunder methods like __init__ or __str__ and regular methods
    
    if not attr.startswith('__') and not callable(getattr(person, attr)):
        value = getattr(person, attr)
        
        print(f'{attr}: {value}')

# 输出
# age 30
# name: John Doe

'''
setattr()   函数允许你动态创建一个新属性或更新一个已有属性。语法如下：
setattr(object, attribute_name, value) 
'''

'''
hasattr()  。在你对一个属性执行操作或删除它之前，查看它是否存在。
还有 hasattr()  。在你对一个属性执行操作或删除它之前，查看它是否存在是一个好习惯。这正是 
hasattr(object, attribute_name)  
'''


'''
delattr()  允许你动态删除一个属性：
delattr(object, attribute_name)  
'''
