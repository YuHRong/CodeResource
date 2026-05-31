# __init__ 类的实例

class Car:
    def __init__(self, brand, color):
        self.brand = brand
        self.color = color


# 从 car类中创建两个对象
car1 = Car('Toyota', 'red')
car2 = Car('Lambo', 'green')

print('Car 1 Brand:', car1.brand)
print('Car 1 Color:', car1.color)


print('Car 2 brand:', car2.brand)
print('Car 2 color:', car2.color)