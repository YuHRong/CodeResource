print('Dictionaries 语法')
'''
dictionary = {

    key1: value1,
        key2: value2
}
'''
print('dictionary 示例')

pizza = {

    'name': 'Margherita Pizza',

    'price': 8.9,

    'calories_per_slice': 250,

    'toppings': ['mozzarella', 'basil']
}

'''
该dictionary被赋值给  pizza  变量。它有四个键值点对： name 、 price 、calories_per_slice   和  toppings  。
另一个备选是使用  dict()  构造函数，它从密钥-值点对的序列构建字典。

dictionary 等效语法
dict()   构造函数。这些元组包含第一个元素作为密钥，第二个元素作为值。
'''

pizza = dict([('name', 'Margherita Pizza'), ('price', 8.9), ('calories_per_slice', 250), ('toppings', ['mozzarella', 'basil'])])
print(pizza)

'''
在我们的披萨示例中，如果你想访问  name  的值，你需要写出变量名 
pizza  ，后跟方括弧，和带有引用的密钥  name  ：
'''

pizza['name']
print(pizza['name'])


'''
要更新一个值，你只需添加赋值操作符，后跟新值。
如果字典中不存在该密钥，将创建一个新的键值点对。在较新版本的 Python 中，字典会保留插入顺序。当你需要迭代字典时，这非常有用
'''

pizza['name'] =  'Margherita'

# 现在密钥  name  的值是  'Margherita' ：

print(pizza['name']) # 'Margherita'

'''
字典也有有助于执行常见操作的帮助方法。
.get()
方法检索与密钥关联的值。它类似于我们刚才使用的方括弧表示法，但它的优点是你可以设置一个默认值，因此如果密钥不存在，你不会得到误差：
'''

dict.get(key, default)

'''
在此示例中，如果  toppings   密钥不存在，它将返回一个空列表，这是我们作为第二个参数传递的默认值。但如果 
toppings   存在，它将返回该值：
'''

pizza.get('toppings', []) # ['mozzarella', 'basil']

'''
.keys()
和 
.values()
方法分别返回包含字典中所有密钥和值的视图对象：
'''

pizza.keys()  # dict_keys(['name', 'price', 'calories_per_slice'])

pizza.values()  # dict_values(['Margherita Pizza', 8.9, 250])

## 视图对象只是查看字典内容的一种方式，而不会创建数据的单独拷贝。

'''
.items()
方法返回一个包含字典中所有键值点对的视图对象，包括键和值：
'''

pizza.items()  # dict_items([('name', 'Margherita Pizza'), ('price', 8.9), ('calories_per_slice', 250)])

'''
.clear()
方法会从字典中移除所有的键值对：
'''

pizza.clear()  

'''
.pop()
方法移除你作为第一个参数指定的密钥对应的点对，并返回其值。如果密钥不存在，则返回你作为第二个参数指定的默认值。如果密钥不存在且你未传入默认值，则引起
'''

pizza.pop('name', 'Key not found')  # 'Key not found'

pizza.pop('price', 10)

pizza.pop('total_price') # KeyError

'''在 Python 3.7 及更高版本中， .popitem()  方法会移除最后插入的项：'''

pizza.popitem() # ('calories_per_slice', 250)

'''
.update()
方法使用另一个字典的密钥-值点对来更新密钥-值点对。如果它们有相同的密钥，则其值将被覆盖。
'''

pizza.update({'name': 'Pepperoni Pizza', 'price': 9.9})

