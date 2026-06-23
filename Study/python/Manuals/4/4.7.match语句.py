# match  语句接受一个表达式并把它的值与一个或多个 case 块给出的一系列模式进行比较。
# 这表面上像 C、Java 或 JavaScript（以及许多其他程序设计语言）中的 switch 语句，但其实它更像 Rust 或 Haskell 中的模式匹配。
# 只有第一个匹配的模式会被执行，并且它还可以提取值的组成部分（序列的元素或对象的属性）赋给变量。如果没有匹配的case，则不执行任何分支。
# 最简单的形式是将一个主语值与一个或多个字面值进行比较：

def http_error(status):
 
    match status:
        case 400:
            return "Bad request"
        
        case 404:
            return "Not found"
        
        case 418:
            return "I'm a teapot"
        
        case _:
            return "Something's wrong with the internet"

# 你可以用 |   （“或”）将多个字面值组合到一个模式中：
        case 401 | 403 | 404:

            return "Not allowed"

# point 是一个 (x, y) 元组

match point:
 case (0, 0):
  print('origin')
  
 case (0, y):
  print(f'Y = {y}')
  
 case (x, 0):
  print(f'X = {x}')
  
 case (x, y):
  print(f'X = {x}, Y = {y}')
  
 case _:
  raise ValueError('Not a point')
  
  

class Point:

    def __init__(self, x, y):

        self.x = x

        self.y = y



def where_is(point):

    match point:

        case Point(x=0, y=0):

            print("Origin")

        case Point(x=0, y=y):

            print(f"Y={y}")

        case Point(x=x, y=0):

            print(f"X={x}")

        case Point():

            print("Somewhere else")

        case _:

            print("Not a point")


