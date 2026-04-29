'''
假设我们有一个
products
字典，将每个产品与其价格关联起来：
'''

products = {
    'Laptop': 990,
    'Smartphone': 600,
    'Tablet': 250,
    'Headphones': 70,
}

'''
如果我们想为所有产品提供 20% 折扣，我们可以循环遍历所有的键值点对并修改价格。
可以使用下面方法
.values()
.keys()
.items()
它们返回一个包含字典的值、密钥和键值点对的视图对象。可以在
for循环中使用这些方法来访问字典的内容。
例如：
'''

print('使用 values 方法 打印每个 key 的值')

for price in products.values():

    print(price)

print('使用 key 方法打印 key')

for product in products.keys():

    print(products)

for product in products:

    print(product)

'''
如果你需要同时迭代密钥及其对应的值，这对键值点对的操作完全相同。你只需迭代
products.items()
'''

print('使用 items 方法访问各 key 和元组')

for product in products.items():

    print(product)

## 如果想将 key 和 value 保存到不同的循环变量中，你只需定义它们并用逗号分隔。然后，你可以在循环体中使用。

'''
这里，我们正在定义一个  product  循环变量和一个  price   循环变量。每个变量将保存其对应的值。重要的是要按顺序定义它们——先定义密钥，然后定义值：
'''

for product, price in products.items():
 
    print(product, price)

print('计算每个产品 20% 的折扣')

print('将每个产品乘以0.8\n在重新赋值给 key 的 value')

for product, price in products.items():
 
    products[product] = round(price * 0.8)

print(products)

'''
最后，如果你需要在迭代键值点对的同时跟踪计数器，你可以调用
enumerate()
函数。这个计数器本质上充当该元素在循环中的“索引”或“计数”。
该函数返回一个
enumerate
对象，它为每个键值点对赋值一个整数，类似计数器。你可以从任意数字开始计数，但默认从 0 开始。
'''

print('便利products字典的密钥：')

for product in enumerate(products):

    print(product)
    
# 如果你需要，可以将这些值赋值给单独的循环变量。

'''
使用
index
和
product）。
当使用  enumerate()   时，这就是常见和使用的方式：
'''

for index, product in enumerate(products):

    print(index, product)

'''
如果需要迭代这些值，可以将
products
替换为 
products.values()  ：
'''

print('输出每个元组中的索引和价格')

for price in enumerate(products.values()):

    print(price)
    
print('赋值给单独的循环变量：')

for index, price in enumerate(products.values()):
 
    print(index, price)
    
''' 
使用
products.items()
可以获取整个密钥-值点对，除此之外还有“index”或“counter”：
'''

print('输出每个元组中的索引和 key-value 点对')

for index, product in enumerate(products.items()):
 
    print(index, product)

print('从1开始计数')

for index, product in enumerate(products.items(), 1):
 
    print(index, product)

