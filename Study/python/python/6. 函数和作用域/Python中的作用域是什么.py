# 作用域

## 在Python中，作用域决定了你可以访问变量的位置。它控制着变量的生命周期以及它在代码不同部分中的解析方式。


##局部作用域（L）：在函数或类中定义的变量。
###局部作用域意味着在函数或类中声明的变量只能在该函数或类中访问。

def my_func():
    my_var = 10
    print(my_var    )
###在这种情况下，该 my_func 函数拥有自己的作用域，无法从函数外部访问。调用该函数会输出结果，但在函数外部打印该函数会导致输出错误：

##封闭作用域（E）：在封闭或嵌套函数中定义的变量。
###封闭作用域意味着嵌套在另一个函数中的函数可以访问它所嵌套的函数的变量。

def outer_func():
    msg = 'Hello there!'
    
    res = ""   # Declare res in the enclosing scope
    def inner_func():
        nonlocal res  # Allow modification of an enclosing variable
        print(msg)
    inner_func()
outer_func() # Hello there!

###在这个例子中，内部函数 inner_func 可以自由访问 msg  外部函数中定义的变量outer_func  。但是请注意，外部函数不能访问任何嵌套函数中定义的变量：


##全局作用域（G）：在模块或文件顶层定义的变量。
## 全局作用域  指的是在任何函数或类之外声明的变量，这些变量可以从程序中的任何位置访问。例如，即使在未定义该变量的函数内部，也可以访问该变量。
my_var =  100
def show_var():

    print(my_var)

show_var() # 100
print(my_var) # 100

### 如果你想让函数内部定义的局部作用域变量全局可访问，可以使用global  关键字：

def show_vars() :

    global my_var_2

    my_var_2 = 10

    print(my_var_1)

    print(my_var_2)

show_vars() # 7 10
# my_var_2 is now a global variable and can be accessed anywhere in the program
print(my_var_2) # 10
###您还可以使用 global 关键字来修改全局变量：
my_var = 10  # A global variable
def change_var():

    global my_var  # Allows modification of a global variable

    my_var = 20

change_var()
print(my_var)  # my_var is now modified globally to 20

##内置作用域（B）：Python 中预定义函数、模块、关键字和对象的保留名称。
##内置作用域  指的是 Python 的所有内置函数、模块和关键字，它们在程序中的任何位置都可用：


print(str(45)) # '45'
print(type(3.14)) # <class 'float'>
print(isinstance(3, str)) # False

