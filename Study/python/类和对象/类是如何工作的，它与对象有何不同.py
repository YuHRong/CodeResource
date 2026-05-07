# 使用 class 关键字，后跟类名家冒号，来定义一个类
# 属性类似于类中的变量，用于存储数据。方法是定义在类内的函数，是用类创建的对象可以执行的动作。

print('类示例')

class ClassName:
    
    def __init__(self, name, age):

        self.name = name
        self.age = age
    
def sammple_method(self):

    print(self.name.upper())

'''
def 
__init__(self, name, age)
是在新建对象时自动调用的特殊方法。
它初始化将由类创建的对象的属性。
除此之外，
__init__
的第一个参数总是对正在创建或使用的特定对象的引用。
按照惯例，这个参数命名为 
self
，但从技术上讲，你可以使用任何名称。
self
让你访问对象自身的属性和方法。
self.name = name
和
self.age = age
是对象拥有的属性。
• def sample_method(self):
是每个创建的对象都可以调用的方法。
print(self.name.upper())
是 sample_method
方法将要执行的操作，在这个分支中，它打印大写的名字。
'''

print('dog 示例')

class Dog:
 
    def __init__(self, aname, age):
        
        self.name = self.name
        self.age = age
        
def bark(self):

    print(f'{self.name.upper()} says woof woof!')
    
# 使用  Dog   类，你可以创建一个对象。以下是从类创建对象的基本语法：

# object_1 = ClassName(attribute_1, attribute_2)

# object_2 = ClassName(attribute_1, attribute_2)

# object_1 = ClassName(attribute_1, attribute_2)

# object_2 = ClassName(attribute_1, attribute_2)
# 你也可以从每个对象调用类中定义的任何方法：
# object_1.method_name()

# object_2.method_name()

print('使用 类创建两条狗')

class Dog:
 
    def __init__(self, name, age):

        self.name = name
        self.age = age
        
def bark(self):
 
        print(f"{self.name.upper()} says woof woof! I'm {self.age} years old")
        
dog_1 = Dog("Jack", 3)

dog_2 = Dog("Thatcher", 5)

#调用bark方法

dog_1.bark()     # 输出：JACK says woof woof! I'm 3 years old

dog_2.bark()     # 输出：THATCHER says woof woof! I'm 5 years old

