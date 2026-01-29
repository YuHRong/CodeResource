# bool() 函数用于将其他值转换为布尔值
print(bool(0))      # False
print(bool(1))      # True
print(bool(""))     # False
print(bool(''))     # False
print(bool("Hello")) # True

# and 运算符：当两个操作数都为 True 时，结果为 True，否则为 False
print(True and True)   # True
print(True and False)  # False
print(False and True)  # False
print(False and False) # False

is_citizen = True
age = 25
if is_citizen and age >= 18:
    print("You are eligible to vote.")
else:
    print("You are not eligible to vote.")

# or 运算符：当至少有一个操作数为 True 时，结果为 True，否则为 False
print(True or True)    # True
print(True or False)   # True
print(False or True)   # True

is_employed = False
age = 19
print(age or is_employed)  # True

age = 19
is_student = True
if age < 18 or is_student:

    print('You are eligible for a student discount') # You are eligible for a student discount
else:

    print('You are not eligible for a student discount')


    #not 运算符：用于取反布尔值
print(not True)   # False
print(not'')     # True 
print(not'Hello world!') # False
print(not 0)    # True
print(not 42)   # False

## 在条件语句中，通常使用not运算符来检查某个值是否为真

is_admin = False
if not is_admin:
    print("Access denied. Admins only.")
else:
    print("Welcome, Admin!")