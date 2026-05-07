'''
属性是属于对象的变量，因此它们保存数据。属性有两种：实例属性和类属性。
实例属性对于从类创建的每个对象都是唯一的，通常通过
__init__
方法设置。另一方面，类属性属于类本身，并由该类的所有实例共享。
'''

print('实例属性和类属性的示例，以及如何从对象中访问。')

class Dog:
    
    species = "French Bulldog"    # 这是一个类属性
    
    def _init__(self, name):
        
        self.name = name    # 这是一个实例属性
print(Dog.species)    # 访问类属性

dog1 = Dog("Jack")   # 创建一个对象
print(dog1.name)     # 访问实例属性,输出 Jack
print(dog1.species)  # 访问类属性,输出 French Bulldog

dog2 = Dog("Tom")  # 创建另一个对象
print(dog2.name)    # 访问实例属性,输出 Tom
print(dog2.species) # 访问类属性,输出 French Bulldog


print('汽车示例')

class Car:

    def __init__(self, color, model) :

        self.color =  color
        self.model =  model

car_1 = Car("red", "Toyota Corolla")

car_2 = Car("green", "Lamborghini Revuelto")
print(car_1.model) # Toyota Corolla
print(car_2.model) # Lamborghini Revuelto
print(car_1.color) # red
print(car_2.color) # green

'''
方法是定义在类内部的函数。通过它们，任何从类定义的对象都可以执行作用于或修改其自身数据的操作。你也可以通过点表示法访问方法。
'''

class Dog:

   species = "French Bulldog"


   def __init__(self, name):

     self.name =  name

   
def bark(self):

       return f"{self.name} says woof woof!"


jack = Dog("Jack")

jill = Dog("Jill")
print(jack.bark()) # Jack says woof woof!
print(jill.bark()) # Jill says woof woof!


# Car   类也可以有一个  describe   方法：
class Car:

    def __init__(self, color, model):

        self.color = color  # Instance attribute

        self.model = model  # Instance attribute


    def describe(self):

        return f"This car is a {self.color} {self.model}"


car_1 = Car("red", "Toyota Corolla")

car_2 = Car("green", "Lamborghini Revuelto")
print(car_1.describe()) # This car is a red Toyota Corolla
print(car_2.describe()) # This car is a green Lamborghini Revuelto

