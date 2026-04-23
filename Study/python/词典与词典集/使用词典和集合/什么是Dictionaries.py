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